using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PluginInterfaces;
using System.Reflection;
using System.IO;
using System.Windows.Forms;

namespace EIS.Forms
{
    partial class FormMain
    {
        #region Plugin
        private AvailablePlugins colAvailablePlugins = new AvailablePlugins();
        private void LoadPlugins()
        {
            try
            {
                //First empty the collection, we're reloading them all
                colAvailablePlugins.Clear();

                //Go through all the files in the plugin directory
                foreach (string fileOn in Directory.GetFiles(Application.StartupPath + @"\Plugins"))
                {
                    FileInfo file = new FileInfo(fileOn);

                    //Preliminary check, must be .dll
                    if (file.Extension.Equals(".dll"))
                    {
                        //Add the 'plugin'
                        this.AddPlugin(fileOn);
                    }
                }

                //Add each plugin to the treeview
                foreach (AvailablePlugin pluginOn in colAvailablePlugins)
                {
                    toolStripMenuItemAditionally.DropDownItems.Add(pluginOn.Instance.MenuItem);
                }
            }
            catch { }
            if (toolStripMenuItemAditionally.DropDownItems.Count == 0)
                toolStripMenuItemAditionally.Visible = false;
        }
        private void AddPlugin(string FileName)
        {
            //Create a new assembly from the plugin file we're adding..
            Assembly pluginAssembly = Assembly.LoadFrom(FileName);

            //Next we'll loop through all the Types found in the assembly
            foreach (Type pluginType in pluginAssembly.GetTypes())
            {
                if (pluginType.IsPublic) //Only look at public types
                {
                    if (!pluginType.IsAbstract)  //Only look at non-abstract types
                    {
                        //Gets a type object of the interface we need the plugins to match
                        Type typeInterface = pluginType.GetInterface("PluginInterfaces.IPlugin", true);

                        //Make sure the interface we want to use actually exists
                        if (typeInterface != null)
                        {
                            //Create a new available plugin since the type implements the IPlugin interface
                            AvailablePlugin newPlugin = new AvailablePlugin();

                            //Set the filename where we found it
                            newPlugin.AssemblyPath = FileName;

                            //Create a new instance and store the instance in the collection for later use
                            //We could change this later on to not load an instance.. we have 2 options
                            //1- Make one instance, and use it whenever we need it.. it's always there
                            //2- Don't make an instance, and instead make an instance whenever we use it, then close it
                            //For now we'll just make an instance of all the plugins
                            newPlugin.Instance = (IPlugin)Activator.CreateInstance(pluginAssembly.GetType(pluginType.ToString()));

                            //Set the Plugin's host to this class which inherited IPluginHost
                            newPlugin.Instance.Host = this;

                            //Call the initialization sub of the plugin
                            newPlugin.Instance.Initialize();

                            //Add the new plugin to our collection here
                            this.colAvailablePlugins.Add(newPlugin);

                            //cleanup a bit
                            newPlugin = null;
                        }

                        typeInterface = null; //Mr. Clean			
                    }
                }
            }

            pluginAssembly = null; //more cleanup
        }
        /// <summary>
        /// Unloads and Closes all AvailablePlugins
        /// </summary>
        public void ClosePlugins()
        {
            foreach (AvailablePlugin pluginOn in colAvailablePlugins)
            {
                pluginOn.Instance.Dispose();
                pluginOn.Instance = null;
            }
            colAvailablePlugins.Clear();
        }
        /// <summary>
        /// Displays a feedback dialog from the plugin
        /// </summary>
        /// <param name="Feedback">String message for feedback</param>
        /// <param name="Plugin">The plugin that called the feedback</param>
        public void Feedback(string Feedback, IPlugin Plugin)
        {
        }
        #endregion
    }

    /// <summary>
    /// Collection for AvailablePlugin Type
    /// </summary>
    public class AvailablePlugins : System.Collections.CollectionBase
    {
        //A Simple Home-brew class to hold some info about our Available Plugins

        /// <summary>
        /// Add a Plugin to the collection of Available plugins
        /// </summary>
        /// <param name="pluginToAdd">The Plugin to Add</param>
        public void Add(AvailablePlugin pluginToAdd)
        {
            this.List.Add(pluginToAdd);
        }

        /// <summary>
        /// Remove a Plugin to the collection of Available plugins
        /// </summary>
        /// <param name="pluginToRemove">The Plugin to Remove</param>
        public void Remove(AvailablePlugin pluginToRemove)
        {
            this.List.Remove(pluginToRemove);
        }

        /// <summary>
        /// Finds a plugin in the available Plugins
        /// </summary>
        /// <param name="pluginNameOrPath">The name or File path of the plugin to find</param>
        /// <returns>Available Plugin, or null if the plugin is not found</returns>
        public AvailablePlugin Find(string pluginNameOrPath)
        {
            AvailablePlugin toReturn = null;

            //Loop through all the plugins
            foreach (AvailablePlugin pluginOn in this.List)
            {
                //Find the one with the matching name or filename
                if ((pluginOn.Instance.Name.Equals(pluginNameOrPath)) || pluginOn.AssemblyPath.Equals(pluginNameOrPath))
                {
                    toReturn = pluginOn;
                    break;
                }
            }
            return toReturn;
        }
    }

    /// <summary>
    /// Data Class for Available Plugin.  Holds and instance of the loaded Plugin, as well as the Plugin's Assembly Path
    /// </summary>
    public class AvailablePlugin
    {
        //This is the actual AvailablePlugin object.. 
        //Holds an instance of the plugin to access
        //ALso holds assembly path... not really necessary
        private IPlugin myInstance = null;
        private string myAssemblyPath = "";

        public IPlugin Instance
        {
            get { return myInstance; }
            set { myInstance = value; }
        }
        public string AssemblyPath
        {
            get { return myAssemblyPath; }
            set { myAssemblyPath = value; }
        }
    }
}
