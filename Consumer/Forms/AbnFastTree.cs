using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FastTreeNS;
using Consumer.Classes;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Reflection;
using Constants;
using Legal.Forms;
using Documents.Forms.JournalCalcLoss;
using Legal.Forms.ActCheck;
using Legal.Forms.Meter;
using SchemeModelN;
using System.Data.SqlClient;
using SchemeModelN.Calculations;
using System.Collections;
using References;
using Library;
using DataSql;
using NLog;
using TV = Consumer.Classes.TreeViewConverter;
using Excel = Microsoft.Office.Interop.Excel;
using ControlsLbr;



namespace Consumer.Forms
{
    public partial class AbnFastTree: FormLbr.FormBase
    {

        #region инициализация, конструктор, загрузка формы, фоновые потоки

        #region переменные класса

        // дерево адресов
        private Node root;
        private TabControlHelper tch;
        private int idnode;
        private string level;

        // дерево подстанций
        private Node root2;
        private TabControlHelper tch2;
        private int idnode2;
        private string level2;

        // флаги существования дерева
        private bool tree1;
        private bool tree2;
        private bool tree3;
        private bool tree4;

        public delegate void MyDelegate(); // для доступа к элементам из другого потока
        public delegate void MyDelegate2(); // для доступа к элементам из другого потока

        private ElectricModel electricModel;
        private DataTable dtSchmCable = new DataTable("SchmCable");
        private List<int> listElectricObect = new List<int>();
        private ArrayList list;
        private Thread mythread;
        private Thread thread_SchmLink;
        private string idSubStation_Save;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private int numer;
        private Node nodeSubStation;
        DataTable dt;
        private List<string> station;

        //private Dictionary<int, string> levelBox = new Dictionary<int, string>;
        //private int key;

        private string allTree;

        #endregion

        // конструктор класса
        public AbnFastTree()
        {
            InitializeComponent();
            tch2 = new TabControlHelper(tabControlInfo, substation);
            tch2.ShowAllPages();
            tch = new TabControlHelper(tabControlInfo, info);
        }

        // загрузка формы
        private void AbnFastTree_Load(object sender, EventArgs e)
        {
            mythread = new Thread(fornewthread);
            mythread.Start();

            thread_SchmLink = new Thread(fornewthread2);
            thread_SchmLink.Start();

            // выбираем в качестве текущей вкладку с адресами
            tabControlTree.SelectedIndex = 0;
            // и создаем дерево адресов
            CreateTree();
            ft.Build(root);
            idnode = 0;
            tree1 = true;
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;

            SelectSqlData(dsFastTree , dsFastTree.tG_PeriodCalc, true);
            dtBegin.Value = new DateTime((int)dsFastTree.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsFastTree.tG_PeriodCalc.Rows[0]["MonthCalc"], 1);
            dtEnd.Value = new DateTime((int)dsFastTree.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsFastTree.tG_PeriodCalc.Rows[0]["MonthCalc"], dtBegin.Value.AddMonths(1).AddDays(-1).Day);


        }

        // Загрузка в фоновом потоке данных о контрагентах
        private void fornewthread()
        {
            if (dsFastTree.vMap_FastTree_AbnObjMeter.Rows.Count == 0)
            {
                this.SelectSqlData(dsFastTree, dsFastTree.vMap_FastTree_AbnObjMeter, true, " order by AbnName, ObjName, Meter");
                BeginInvoke(new MyDelegate(ChangeCursor));
            }
        }

        // Загрузка в фоновом потоке данных о привязках 
        private void fornewthread2()
        {
            electricModel = new ElectricModel();
            electricModel.SqlSettings = this.SqlSettings;
            electricModel.LoadSchema(true);
        }

        // Возвращаем курсор по умолчанию
        public void ChangeCursor()
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        #endregion 

        #region работа с деревьями

        // менеджер деревьев
        private void tabControlTree_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControlTree.SelectedIndex == 0)
            {
                level = "info";
                tch.ChangePage(level);
                statusAbn.Text = "";
                this.statusAbn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            }
            else if (tabControlTree.SelectedIndex == 1)
            {
                thread_SchmLink.Join();
                CreateTree2();
                ft2.Build(root2);
                idnode2 = 0;
                level = "substation";
                tch2.ChangePage(level);
                statusAbn.Text = "Юридические и физические лица запитанные от подстанции";
                this.statusAbn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            }
            else if (tabControlTree.SelectedIndex == 2)
            {
                level = "info";
                tch.ChangePage(level);
                statusAbn.Text = "";
            }
            else if (tabControlTree.SelectedIndex == 3)
            {
                level = "info";
                tch.ChangePage(level);
                statusAbn.Text = "";
            }
        }
        
        #region Дерево адресов

        // создаем основное дерево адресов
        private void CreateTree()
        {
            root = new Node("Root");
            this.SelectSqlData(dsFastTree, dsFastTree.vMap_FastTree, true, "order by City, Street, Home2, Home");

            var queryNestedGroups =
                    from grp in dsFastTree.vMap_FastTree.AsEnumerable()
                    group grp by new { grp.City, grp.idCity } into newGroup1
                    from newGroup2 in
                        (from grp in newGroup1
                         group grp by new { grp.Street, grp.idStreet })
                    group newGroup2 by newGroup1.Key;

            foreach (var outerGroup in queryNestedGroups)
            {
                var city = new Node(outerGroup.Key.City, outerGroup.Key.idCity);
                city.IsFinish = false;
                city.Level = "city";
                root.AddChild(city);
                foreach (var innerGroup in outerGroup)
                {
                    var street = new Node(innerGroup.Key.Street, innerGroup.Key.idStreet);
                    city.AddChild(street);
                    street.IsFinish = false;
                    street.Level = "street";
                    foreach (var innerGroupElement in innerGroup)
                    {
                        var home = new Node(innerGroupElement.Home, innerGroupElement.idMap);
                        home.IsFinish = true;
                        home.Level = "home";
                        street.AddChild(home);
                        var abn = new Node("Нет объектов");
                        home.AddChild(abn);
                        home.IsFinish = true;
                    }
                }
            }
        }

        // добавляем 3 уровня с абонентами
        private void ft_NodeExpandedStateChanged(object sender, NodeExpandedStateChangedEventArgs e)
        {
            mythread.Join();
            if ((e.Node as Node).IsFinish == true)
            {
                int map = (e.Node as Node).idNode;
                if (dsFastTree.vMap_FastTree_AbnObjMeter.Rows.Count > 0)
                {
                    (e.Node as Node).IsFinish = false;

                    var queryNestedGroups =
                            from grp in dsFastTree.vMap_FastTree_AbnObjMeter.AsEnumerable().Where
                            (row => row.Field<int>("idMap") == map)
                            group grp by new {grp.TypeAbn, grp.AbnName, grp.idAbn } into newGroup1
                            from newGroup2 in
                                (from grp in newGroup1
                                 group grp by new { grp.ObjName, grp.idObj })
                            group newGroup2 by newGroup1.Key;

                    foreach (var outerGroup in queryNestedGroups)
                    {
                        var abon = new Node(outerGroup.Key.AbnName, outerGroup.Key.idAbn);
                        (e.Node as Node).AddChild(abon);
                        abon.IsFinish = false;
                        abon.Level = "abn";
                        abon.TypeNode = outerGroup.Key.TypeAbn;
                        foreach (var innerGroup in outerGroup)
                        {
                            var obj = new Node(innerGroup.Key.ObjName, innerGroup.Key.idObj);
                            abon.AddChild(obj);
                            obj.IsFinish = false;
                            obj.Level = "obj";
                            obj.TypeNode = outerGroup.Key.TypeAbn;
                            if (outerGroup.Key.TypeAbn == 206)
                                obj.Title = "Физлицо";
                            foreach (var innerGroupElement in innerGroup)
                            {
                                var meter = new Node(innerGroupElement.Meter, innerGroupElement.idMeter);
                                obj.AddChild(meter);
                                meter.IsFinish = false;
                                meter.Level = "meter";
                                meter.TypeNode = outerGroup.Key.TypeAbn;
                            }
                        }
                    }

                    (e.Node as Node).Childs.RemoveAt(0);
                    ft.Build(root);
                }
            }
 
        }

        // меняем иконки
        private void ft_NodeIconNeeded(object sender, ImageNodeEventArgs e)
        {
            if ((e.Node as Node).Level == "home")
                e.Result = Consumer.Properties.Resources.homemedium;
            else if ((e.Node as Node).Level == "street") 
                e.Result = Consumer.Properties.Resources.road;
            else if ((e.Node as Node).Level == "city")
                e.Result = Consumer.Properties.Resources.cities;
            else if ((e.Node as Node).Level == "abn")
                e.Result = Consumer.Properties.Resources._object;
            else if ((e.Node as Node).Level == "meter")
                e.Result = Consumer.Properties.Resources.meter;
            else if ((e.Node as Node).Level == "obj")
                e.Result = Consumer.Properties.Resources.abonent;

        }

        #endregion

        #region Дерево подстанций

        private void CreateTree2()
        {
            dt = new DataTable("dtSubTree");

            dt.Columns.Add(new DataColumn("Tag", typeof(int)));
            dt.Columns.Add(new DataColumn("idParent", typeof(int)));
            dt.Columns.Add(new DataColumn("Title", typeof(string)));
            dt.Columns.Add(new DataColumn("Level", typeof(string)));

            list = new ArrayList();
            int flag = 0;

            root2 = new Node("Root");
            // таблица кабелей
            References.SchemeTables.GetTableSchmCable(dtSchmCable, SqlSettings);

            var s1 = electricModel.Objects.Where(w => w.GetType().Equals(typeof(ElectricSubstation)));
            var schmObjCp = s1.Where(w => ((ElectricSubstation)w).TypeSubstation.Equals(eTypeRectangleTool.CP));

            foreach (var itemCP in schmObjCp)
            {
                listElectricObect.Clear();

                //if (itemCP.FullName != "ЦП-ПС ЦЕНТРАЛЬНАЯ - 110/10")
                //    continue;

                //if (itemCP.FullName != "ЦП-ПС СВИЯГА - 110/6 ")
                //    continue;

                // Добавляем узел центра питания - первый уровень
                var SubNodeTreeCP = new Node(itemCP.FullName, itemCP.Id);
                root2.AddChild(SubNodeTreeCP);
                SubNodeTreeCP.Level = "Центр";
                
                // Tag idParent Title
                dt.Rows.Add(new object[] {itemCP.Id, 0, itemCP.FullName, "Центр"});

                // Выдернем все щины центра питания
                var c0 = itemCP.ChildObjects.Where(w => w.GetType().Equals(typeof(ElectricBus)));
                var schmObjBus = c0.OrderBy(c => c.ToString());

                // Выдерним все ячейки центра питания
                var c1 = itemCP.ChildObjects.Where(w => w.GetType().Equals(typeof(ElectricLine)));
                var schmObjCells = c1.Where(w => ((ElectricLine)w).IsCell());

                foreach (var itemBus in schmObjBus)
                {
                    // Добавляем узел шин - второй уровень

                    var SubNodeTreeBus = new Node(itemBus.ToString(), itemBus.Id);
                    SubNodeTreeCP.AddChild(SubNodeTreeBus);
                    SubNodeTreeBus.Level = "Шина ЦП";

                    // получим точки принадлежащие щине
                    var pointEnds = itemBus.ChildObjects.Where(w => w.GetType().Equals(typeof(ElectricPoint)));

                    // Выбрать ячейки, принадлжащие текущей щине
                    foreach (ElectricLine line in schmObjCells)
                    {
                        // если ячейки еще нет в списке
                        if (!listElectricObect.Contains(line.Id))

                            foreach (ElectricPoint point in line.Ends)
                            {
                                if (pointEnds.Contains(point))
                                {
                                    listElectricObect.Add(line.Id);

                                    // Добавляем узел ячейки - третий уровень

                                    var SubNodeTreeCell = new Node(line.ToString(), line.Id);
                                    SubNodeTreeBus.AddChild(SubNodeTreeCell);
                                    SubNodeTreeCell.Level = "Ячейка ЦП";

                                    dt.Rows.Add(new object[] { line.Id, itemCP.Id, line.ToString(), "Ячейка ЦП" });


                                    TreeNodeObj treeNodeObj_ = electricModel.PoweringReportForDrawObject(Convert.ToInt32(line.Id), true);

                                    flag = 0;
                                    idSubStation_Save = "";

                                    this.FillTableSubOff(SubNodeTreeCell, treeNodeObj_, flag);
                                    break;
                                }
                            }
                    } 
                } 
            }

            // чистка дерева
            cleanerTreeSub();
        }

        private void FillTableSubOff(Node SubNodeTree, TreeNodeObj RootNodeObj, int flag)
        {
            if (RootNodeObj.Tag != null)
            {

                if (RootNodeObj.Tag is ElectricBus)
                {
                    if (this.listElectricObect.Contains(((ElectricBus)RootNodeObj.Tag).Id))
                    {
                        return;
                    }
                    this.listElectricObect.Add(((ElectricBus)RootNodeObj.Tag).Id);
                }

                if (RootNodeObj.Tag is ElectricLine)
                {
                    ElectricLine electricLine = (ElectricLine)RootNodeObj.Tag;
                    if (electricLine.IsCell())
                    {
                        ElectricBus electricBus = null;
                        foreach (ElectricPoint electricPoint in electricLine.Ends)
                        {
                            if (electricPoint.Parent is ElectricBus)
                            {
                                electricBus = (ElectricBus)electricPoint.Parent;
                                if (electricBus.TypeBus == eTypeShinaTool.Shina_10 || electricBus.TypeBus == eTypeShinaTool.Shina_110 || electricBus.TypeBus == eTypeShinaTool.Shina_35)
                                {
                                    break;
                                }
                                if (electricBus.TypeBus == eTypeShinaTool.Shina_6)
                                {
                                    break;
                                }
                                electricBus = null;
                            }
                        }

                        if (electricBus != null)
                        {

                            if (SubNodeTree == null)
                            {
                                var SubNodeTreeTP = new Node
                                (
                                    electricBus.Parent.ToString(),
                                    electricBus.Parent.Id
                                );
                                SubNodeTree.AddChild(SubNodeTreeTP);
                                SubNodeTreeTP.Level = "substation";

                                var SubNodeTreeTPCell = new Node(electricLine.ToString(), electricLine.Id);
                                SubNodeTreeTP.AddChild(SubNodeTreeTPCell);
                            }
                            else
                            {
                                if (flag != 0)
                                {
                                    // ищем вверх по ветке есть ли узел-подстанция с таким же названием
                                    bool repeatNone = true;
                                    nodeSubStation = SubNodeTree.Parent;
                                    while (nodeSubStation != null)
                                    {
                                        if (nodeSubStation.Level == "substation")
                                        {
                                            if (nodeSubStation.Title == electricBus.Parent.ToString())
                                                repeatNone = false;
                                            break;
                                        }
                                        else
                                            nodeSubStation = nodeSubStation.Parent;
                                    }

                                    // повторения нет, значит рисуем узел с подстанцией
                                    if (repeatNone)
                                    {
                                        var SubNodeTreeTP = new Node
                                        (
                                            electricBus.Parent.ToString(),
                                            //+ " / " + electricBus.ToString(),
                                            electricBus.Parent.Id
                                        );
                                        SubNodeTree.AddChild(SubNodeTreeTP);
                                        SubNodeTreeTP.Level = "substation";
                                        SubNodeTree = SubNodeTreeTP;

                                        int idParent = 0;
                                        if (nodeSubStation != null)
                                            idParent = nodeSubStation.idNode;
                                        dt.Rows.Add(new object[] { electricBus.Parent.Id, idParent, electricBus.Parent.ToString(), "substation" });
                                        idSubStation_Save = electricBus.Parent.ToString();

                                        var SubNodeTreeTPCell = new Node(electricLine.ToString(), electricLine.Id);
                                        SubNodeTreeTP.AddChild(SubNodeTreeTPCell);
                                        SubNodeTreeTPCell.Level = "cell";
                                        SubNodeTree = SubNodeTreeTPCell;

                                    }
                                    else
                                    {
                                        string strCell = electricLine.ToString();
                                        if ((strCell.IndexOf("ШМ", 0) == -1) && (strCell.IndexOf("Тр", 0) == -1))
                                        {
                                            var SubNodeTreeTPCell = new Node(electricLine.ToString(), electricLine.Id);
                                            SubNodeTree.AddChild(SubNodeTreeTPCell);
                                            SubNodeTreeTPCell.Level = "cell";
                                            SubNodeTree = SubNodeTreeTPCell;
                                        }
                                    }
                                }
                                flag = 1;
                            }
                        }

                    }
                }
            }
            foreach (TreeNodeObj node in RootNodeObj.Nodes)
            {
                this.FillTableSubOff(SubNodeTree, node, 1);
            }

        }
        private void ft2_NodeIconNeeded(object sender, ImageNodeEventArgs e)
        {
            if ((e.Node as Node).Level == "Подстанция")
                e.Result = Consumer.Properties.Resources.meter;
            else if ((e.Node as Node).Level == "Центр")
                e.Result = Consumer.Properties.Resources.homemedium;
            else if ((e.Node as Node).Level == "Шина")
                e.Result = Consumer.Properties.Resources.road;
            else if ((e.Node as Node).Level == "Ячейка")
                e.Result = Consumer.Properties.Resources.homesmall;
        }

        // чистим дерево подстанций
        private void cleanerTreeSub()
        {
            Queue<Node> nodeQueue = new Queue<Node>();
            nodeQueue.Enqueue(root2);
            allTree = "";
            // признак все детки ячейки
            bool сhildrenCell = false;
            // признак родительский узел ячейка 
            bool parentCell;
            // родительский узел 
            Node parentNode = root2;

            while (nodeQueue.Count > 0)
            {
                // удаляем самый старый элемент из очереди и 
                // делаем его текущим родительским узлом
                // очередь двигается
                Node currentNode = nodeQueue.Dequeue();

                List<Node> children = currentNode.Childs;
                // заталкиваем всех деток родительского узла в очередь
                сhildrenCell = true;
                foreach (Node child in children)
                {
                    // проверяем все ли детки являются ячейками
                    if (child.Level != "cell")
                        сhildrenCell = false;
                    nodeQueue.Enqueue(child);
                }
                // если родительский узел ячейка и все его детки ячейки
                // меняем родителя у деток на предыдущий узел
                if (сhildrenCell && currentNode.Level == "cell" && children.Count > 0)
                {
                    foreach (Node child in children)
                    {
                        currentNode.Parent.AddChild(child);
                    }
                    currentNode.Parent.RemoveChild(currentNode);
                }
            }
        }

        // обработчики
        private void ft2_NodeSelectedStateChanged(object sender, NodeSelectedStateChangedEventArgs e)
        {
            level = (e.Node as Node).Level;
            idnode = (e.Node as Node).idNode;
            tch2.ChangePage(level, idnode);

            // очистим гриды dgvSubStation_Person и dgvSubStation
            dsFastTree.vL_SchmAbnFull_2020.Rows.Clear();

            statusAbn.Text = "Юридические и физические лица запитанные от подстанции " + e.Node;
            this.statusAbn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }
        private void tsbGetSubStation_Object_Click(object sender, EventArgs e)
        {
            if (ft2.SelectedNode != null)
            {
                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                if ((ft2.SelectedNode as Node).Level == "substation")
                {
                    GetListAbnObj_LinqSub(1);
                }
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }
            else
                MessageBox.Show("Выберите подстанцию ..");
        }

        private void tsbGetSubStation_ObjectAll_Click(object sender, EventArgs e)
        {
            if (ft2.SelectedNode != null)
            {
                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                if ((ft2.SelectedNode as Node).Level == "substation")
                {
                    GetListAbnObj_LinqSub(2);
                }
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }
            else
                MessageBox.Show("Выберите подстанцию ..");
        }
        // список всех контрагентов запитанных от подстанции
        private void GetListAbnObj_LinqSub(int metod, int idSub = 0)
        {
            // определить тип узла (подстанция, шина, ячейка)
            // если ячейка берем все подключенные к ячейке, шине, подстанции
            // цвет синий - только к подстанции
            // цвет красный - дополнительно к шине
            // обычный цвет - к ячейке
            // два метода либо по цепочке либо все подключенные к ТП

            // получить ID узла дерева подстанций
            // загрузить объекты привязанные к этому ID 

            int idSchmObj = 0;
            if (idSub > 0)
                idSchmObj = idSub;
            else
                idSchmObj = (ft2.SelectedNode as Node).idNode;

            ElectricObject electricObject = electricModel.GetElectricObjectById(idSchmObj);
            List<ElectricObject> ListAllObject;

            if (metod == 1)
            {
                ListAllObject = electricModel.PoweringReportForDrawObject(electricObject, true, true);
            }
            else
            {
                ListAllObject = electricModel.PoweringReportForDrawObject(electricObject, true, false);
            }

            int nn = ListAllObject.Count;

            DateTime dateTime = System.DateTime.Now;
            DataTable dt = dsFastTree.vL_SchmAbnFull_2020;
            DataSql.SQLSettings sqlsettings = this.SqlSettings;

            Tables.SChmAbnFull_2020(dt, sqlsettings, ListAllObject, dateTime);
        }

        #endregion

        #region Контекстное меню для узлов дерева

        // добавить
        private void contextMenuAdd_Click(object sender, EventArgs e)
        {
            if ((ft.SelectedNode as Node).Level == "abn")
            {
            }
            else if ((ft.SelectedNode as Node).Level == "obj")
            {
                int idAbn = (ft.SelectedNode as Node).Parent.idNode;
                Legal.Forms.Object.FormObjAE fAdd = new Legal.Forms.Object.FormObjAE(idAbn, -1, Legal.Forms.Object.FormObjAE.ActionAbnObj.Add, -1, Legal.Forms.Object.FormObjAE.ActionAbnObjReg.Add);
                fAdd.SqlSettings = this.SqlSettings;
                fAdd.ShowDialog();
                ft.Build(root);
            }
            else if ((ft.SelectedNode as Node).Level == "meter")
            {
                int idObj = (ft.SelectedNode as Node).Parent.idNode;
                Legal.Forms.Meter.FormNewPoint fAdd = new Legal.Forms.Meter.FormNewPoint(idObj);
                fAdd.SqlSettings = this.SqlSettings;
                fAdd.ShowDialog();
                ft.Build(root);
            }

        }
        // редактировать
        private void contextMenuEdit_Click(object sender, EventArgs e)
        {
            if ((ft.SelectedNode as Node).Level == "obj")
            {
                int idAbn = (ft.SelectedNode as Node).Parent.idNode;
                int idObj = (ft.SelectedNode as Node).idNode;
                this.SelectSqlData(dsFastTree.vG_AbnObj, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll
                                                                  + ") and id = " + idObj.ToString(), null, false, 1);
                int idObjReg = 0;
                if (dsFastTree.vG_AbnObj.Rows[0]["idReg"] != System.DBNull.Value)
                {
                    idObjReg = Convert.ToInt32(dsFastTree.vG_AbnObj.Rows[0]["idReg"]);
                }

                Legal.Forms.Object.FormObjAE fAdd = new Legal.Forms.Object.FormObjAE(idAbn, idObj, Legal.Forms.Object.FormObjAE.ActionAbnObj.Edit, idObjReg, Legal.Forms.Object.FormObjAE.ActionAbnObjReg.Edit); ;
                fAdd.SqlSettings = this.SqlSettings;

                if (fAdd.ShowDialog() == DialogResult.OK)
                {
                    this.SelectSqlData(dsFastTree, dsFastTree.vG_AbnObj, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and idAbn = " + idAbn.ToString());
                }
            }

            else if ((ft.SelectedNode as Node).Level == "abn")
            {
                int idAbn = (ft.SelectedNode as Node).idNode;
                FormAbnAddEdit fAdd = new FormAbnAddEdit(idAbn, false);
                fAdd.SqlSettings = this.SqlSettings;
                fAdd.ShowDialog();
            }

            else if ((ft.SelectedNode as Node).Level == "meter")
            {
                int idObj = (ft.SelectedNode as Node).Parent.idNode;
                int idPointReg = (ft.SelectedNode as Node).idNode;
                this.SelectSqlData(dsFastTree, dsFastTree.tPointReg, true, " where id = " + idPointReg.ToString());
                int idPoint = Convert.ToInt32(dsFastTree.tPointReg.Rows[0]["idPoint"]);

                Legal.Forms.Meter.FormMeterAddEdit fAdd = new Legal.Forms.Meter.FormMeterAddEdit(idObj, idPoint, false, true);
                fAdd.SqlSettings = this.SqlSettings;
                fAdd.ShowDialog();
            }

        }
        // посмотреть
        private void contextmenuView_Click(object sender, EventArgs e)
        {
            int idObj = (ft.SelectedNode as Node).Parent.idNode;
            int idPointReg = (ft.SelectedNode as Node).idNode;
            this.SelectSqlData(dsFastTree, dsFastTree.tPointReg, true, " where id = " + idPointReg.ToString());
            int idPoint = Convert.ToInt32(dsFastTree.tPointReg.Rows[0]["idPoint"]);

            Legal.Forms.Meter.FormMeterAddEdit fAdd = new Legal.Forms.Meter.FormMeterAddEdit(idObj, idPoint, true, true);
            fAdd.SqlSettings = this.SqlSettings;

            fAdd.ShowDialog();
        }
        // удалить
        private void contextMenuRemove_Click(object sender, EventArgs e)
        {

        }
        // история
        private void contextMenuHistory_Click(object sender, EventArgs e)
        {
            if ((ft.SelectedNode as Node).Level == "obj")
            {
                int idObj = (ft.SelectedNode as Node).idNode;

                Legal.Forms.Object.FormObjHistory fAdd = new Legal.Forms.Object.FormObjHistory(idObj); ;
                fAdd.SqlSettings = this.SqlSettings;

                fAdd.ShowDialog();
            }
        }
        // менеджер контекстного меню
        private void contextMenuManager(string level)
        {
            if (level == "abn")
            {
                contextMenuAdd.Visible = false;
                contextMenuEdit.Visible = true;
                contextmenuView.Visible = false;
                contextMenuRemove.Visible = false;
                contextMenuHistory.Visible = false;
                contextMenuAdd.Visible = false;
                contextMenuAdd.Text = "Добавить контрагента";
                contextMenuEdit.Text = "Редактировать контрагента";
                contextmenuView.Text = "Посмотреть контрагента";
                contextMenuRemove.Text = "Удалить контрагента";
                contextMenuHistory.Text = "История контрагента";
            }
            else if (level == "obj")
            {
                contextMenuAdd.Visible = true;
                contextMenuEdit.Visible = true;
                contextmenuView.Visible = false;
                contextMenuRemove.Visible = false;
                contextMenuHistory.Visible = true;
                contextMenuAdd.Text = "Добавить объект";
                contextMenuEdit.Text = "Редактировать объект";
                contextmenuView.Text = "Посмотреть объект";
                contextMenuRemove.Text = "Удалить объект";
                contextMenuHistory.Text = "История объекта";
            }
            else if (level == "meter")
            {
                contextMenuAdd.Visible = true;
                contextMenuEdit.Visible = true;
                contextmenuView.Visible = true;
                contextMenuRemove.Visible = false;
                contextMenuHistory.Visible = false;
                contextMenuAdd.Text = "Добавить прибор учета";
                contextMenuEdit.Text = "Редактировать прибор учета";
                contextmenuView.Text = "Посмотреть прибор учета";
                contextMenuRemove.Text = "Удалить прибор учета";
                contextMenuHistory.Text = "История прибора учета";
            }
            else
            {
                contextMenuAdd.Visible = false;
                contextMenuEdit.Visible = false;
                contextmenuView.Visible = false;
                contextMenuRemove.Visible = false;
                contextMenuHistory.Visible = false;
            }

        }

        #endregion

        # region Разные функции

        // менеджер вкладок - меняем вкладки в зависимости от уровня дерева 
        // и загружаем данные для вкладок
        private void ft_NodeSelectedStateChanged(object sender, NodeSelectedStateChangedEventArgs e)
        {
            level = (e.Node as Node).Level;
            idnode = (e.Node as Node).idNode;
            if (tch.ChangePage(level, idnode))
            {
                if (level == "abn")
                {
                    dsFastTree.vG_Abn.Rows.Clear();
                    this.SelectSqlData(dsFastTree, dsFastTree.vG_Abn, true, " where id = " + idnode);
                    txtTypeAbn.Text = Convert.ToString(dsFastTree.vG_Abn.Rows[0]["TypeName"]);
                    txtStatus.Text = Convert.ToString(dsFastTree.vG_Abn.Rows[0]["Status"]);
                    txtTypeDogovor.Text = Convert.ToString(dsFastTree.vG_Abn.Rows[0]["TypeDog"]);
                    txtAbnWorker.Text = Convert.ToString(dsFastTree.vG_Abn.Rows[0]["Famil"]);

                    dsFastTree.tAbnContact.Rows.Clear();
                    this.SelectSqlData(dsFastTree, dsFastTree.tAbnContact, true, " where idAbn = " + idnode + " order by DateChange desc");
                }
                else if (level == "obj")
                {
                    // приборы
                    dsFastTree.vG_ObjMeter.Rows.Clear();
                    this.SelectSqlData(dsFastTree, dsFastTree.vG_ObjMeter, true, " where idAbnObj = " + idnode + " order by DateBegin desc");
                    // начисления
                    dsFastTree.vF_SchetAll.Rows.Clear();
                    this.SelectSqlData(dsFastTree, dsFastTree.vF_SchetAll, true, " where idAbnObj = " + idnode + " order by YearCalc desc, MonthCalc asc");
                    // документы
                    dsFastTree.vAbnObjDoc_List.Rows.Clear();
                    this.SelectSqlData(dsFastTree, dsFastTree.vAbnObjDoc_List, true, " where idAbnObj = " + idnode + " order by DocDate desc");
                    // субчики
                    dsFastTree.vF_ListSubObject.Rows.Clear();
                    this.SelectSqlData(dsFastTree, dsFastTree.vF_ListSubObject, true, " where idObj = " + idnode + " order by abnName");
                    changeChart();
                    // привязки
                    this.SelectSqlData(dsFastTree, dsFastTree.vL_SchmAbn, true, " where idAbnObj = " + idnode + " order by SchmObjName ");
                    UpdateSchmLink();
                }
                else if (level == "meter")
                {
                    dsFastTree.vG_ObjMeterAll.Rows.Clear();
                    int idPointReg = (ft.SelectedNode as Node).idNode;
                    this.SelectSqlData(dsFastTree, dsFastTree.tPointReg, true, " where id = " + idPointReg.ToString());
                    int idPoint = Convert.ToInt32(dsFastTree.tPointReg.Rows[0]["idPoint"]);

                    this.SelectSqlData(dsFastTree, dsFastTree.vG_ObjMeterAll, true, " where PointID = " + idPoint + " order by DateBegin desc");

                    // показания
                    this.SelectSqlData(dsFastTree, dsFastTree.vF_MeterValAll, true, " where MeterID = " + idPointReg + " order by YearCalc asc, MonthCalc asc");
                    // пломбы
                    // документы
                }
            }
            statusAbn.Text = walkTheTree(e.Node as Node);
            contextMenuManager(level);
        }

        // раскраска узлов дерева в зависимости от типа контрагента
        private void ft_NodeForeColorNeeded(object sender, ColorNodeEventArgs e)
        {
            switch ((e.Node as Node).TypeNode)
            {
                case 206: e.Result = Color.Brown; break;
                case 230: e.Result = Color.DarkGreen; break;
                case 231: e.Result = Color.DarkBlue; break;
            }
        }

        // обновление дерева
        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            // выбираем в качестве текущей вкладку с адресами
            tabControlTree.SelectedIndex = 0;
            // и создаем дерево адресов
            CreateTree();
            ft.Build(root);
            idnode = 0;
            tree1 = true;
        }

        // функция которая пробегает по всем родительским узлам
        private string walkTheTree(Node node)
        {
            Node parent = node;
            string result = parent.Title;
            while (true)
            {
                if (parent.Parent.Title == "Root")
                {
                    break;
                }
                result = parent.Parent.Title + ", " + result;
                parent = parent.Parent;
            }
            return result;
        }

        # endregion

        #endregion

        # region работа с вкладками(справа)

        # region вкладка Контрагент
        # endregion

        # region вкладка Объект

        // график начислений
        private void changeChart()
        {
            chartObj_Volume.Series.Clear();
            chartObj_Volume.Series.Add("Объем");
            ChartArea myChartArea = new ChartArea();
            //фон градиентом
            chartObj_Volume.BackColor = Color.MistyRose;
            chartObj_Volume.BackGradientStyle = GradientStyle.DiagonalLeft;
            //границы в современном стиле
            chartObj_Volume.BorderSkin.SkinStyle = BorderSkinStyle.Sunken;
            chartObj_Volume.BorderSkin.PageColor = BackColor;
            chartObj_Volume.Series["Объем"].Color = Color.Gold;
            chartObj_Volume.Series["Объем"].XValueMember = "dtCalc";
            chartObj_Volume.Series["Объем"].YValueMembers = "Quantity";
        }

        //private void tsObj_PeriodVolume_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    dsFastTree.vF_SchetAll.Rows.Clear();
        //    this.SelectSqlData(dsFastTree, dsFastTree.vF_SchetAll, true, " where idAbnObj = " + idnode + " order by dtCalc desc");
        //}

        #region обработчики событий для грида с начислениями объектов

        private void dgvObj_Volume_CellPainting(object sender, DataGridViewCellPaintingEventArgs args)
        {
            if (args.ColumnIndex == 0)
                args.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            // Ignore column and row headers and first row
            if (args.RowIndex < 1 || args.ColumnIndex < 0)
                return;
            if (IsRepeatedCellValue(args.RowIndex, args.ColumnIndex))
            {
                if (args.ColumnIndex == 0)
                    args.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
                args.AdvancedBorderStyle.Top = args.AdvancedBorderStyle.Top;
            }
        }

        private void dgvObj_Volume_CellFormatting(object sender, DataGridViewCellFormattingEventArgs args)
        {
            if (args.RowIndex == 0)
                return;
            if (IsRepeatedCellValue(args.RowIndex, args.ColumnIndex))
            {
                if (args.ColumnIndex == 0)
                {
                    args.Value = string.Empty;
                    args.FormattingApplied = true;
                }
            }
        }

        private bool IsRepeatedCellValue(int rowIndex, int colIndex)
        {
            DataGridViewCell currCell = dgvObj_Volume.Rows[rowIndex].Cells[colIndex];
            DataGridViewCell prevCell = dgvObj_Volume.Rows[rowIndex - 1].Cells[colIndex];

            if ((currCell.Value == prevCell.Value) ||
                (currCell.Value != null && prevCell.Value != null &&
                currCell.Value.ToString() == prevCell.Value.ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region работа с документами объекта

        private void ts_ObjDocument_Edit_Click(object sender, EventArgs e)
        {
            if (ts_ObjDocument_Edit.Enabled && ts_ObjDocument_Edit.Visible)
                EditDocObj();
        }

        private void ts_ObjDocument_Info_Click(object sender, EventArgs e)
        {
            if (dgvObj_ListDocument.CurrentRow != null)
                switch (Convert.ToInt32(dgvObj_ListDocument.CurrentRow.Cells[idDocType.Name].Value))
                {
                    case (int)DocType.DogovorTransferEnergy:
                        break;
                    case (int)DocType.ActUst:
                        break;
                    case (int)DocType.ActDem:
                        break;
                    case (int)DocType.LossCalculation:
                        break;
                    case (int)DocType.ActPerehod:
                        break;
                    // Акт разграничения балансовой принадлежности
                    case (int)DocType.ActLiability:
                    case (int)DocType.ActRBP:
                        Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP frmAktRBP =
                            new Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP(this.SqlSettings, idnode, Convert.ToInt32(dgvObj_ListDocument.CurrentRow.Cells["idDoc"].Value), true);
                        frmAktRBP.MdiParent = this.MdiParent;
                        frmAktRBP.Show();
                        break;
                    case (int)DocType.ActTP:
                        break;
                    case (int)DocType.ActKO:
                    case (int)DocType.ActMeterInstallation:
                    case (int)DocType.ActMeterDismantling:
                    case (int)DocType.ActMeterkReplacement:
                    case (int)DocType.ActCheck:
                        FormDocAct_Check frmActCheck = new FormDocAct_Check(this.SqlSettings, idnode, Convert.ToInt32(dgvObj_ListDocument.CurrentRow.Cells["idDoc"].Value));
                        frmActCheck.ShowDialog();
                        break;
                    case (int)DocType.Dogovor:
                        break;
                    case (int)DocType.DogovorEnergo:
                        break;
                    #region Расчет потерь
                    case (int)TypeCalcLoss.TypeKL:
                    case (int)TypeCalcLoss.TypeVL:
                    case (int)TypeCalcLoss.TypeTrans:
                        ReportCalcLoss();
                        break;
                    #endregion
                    #region акт осмотра эл, выполнения ту, акт о тп
                    case (int)eTypeDocTC.ActTC:
                    case (int)eTypeDocTC.ActElectricalInspection:
                    case (int)eTypeDocTC.ActPerformingTU:
                    case (int)eTypeDocTC.ChangeSwitch:
                        ReportActTC();
                        break;
                    #endregion
                    default:
                        break;
                }

        }

        private void ts_ObjDocument_Del_Click(object sender, EventArgs e)
        {
            if (dgvObj_ListDocument.CurrentRow != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить текущий документ?", "Удаление",
                     MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int idObj = idnode;
                    int idDoc = Convert.ToInt32(dgvObj_ListDocument.CurrentRow.Cells["idDoc"].Value);
                    int idDocType = Convert.ToInt32(dgvObj_ListDocument.CurrentRow.Cells["idDocType"].Value);
                    int DocIndex = dgvObj_ListDocument.CurrentRow.Index;

                    DataSet.dsFastTree ds = new DataSet.dsFastTree();

                    switch (idDocType)
                    {
                        case (int)DocType.ActRBP:

                            this.SelectSqlData(dsFastTree, dsFastTree.tAbnObjDoc_List, true, "where id = " + idDoc);
                            dsFastTree.tAbnObjDoc_List.First().Deleted = !dsFastTree.tAbnObjDoc_List.First().Deleted;
                            dsFastTree.tAbnObjDoc_List.First().EndEdit();
                            if (this.UpdateSqlData(dsFastTree, dsFastTree.tAbnObjDoc_List))
                            {
                                if (dsFastTree.tAbnObjDoc_List.First().Deleted)
                                {
                                    this.SelectSqlData(dsFastTree, dsFastTree.vAbnObjDoc_List, true, " where idAbnObj = " + idObj.ToString() + " order by DocDate desc");

                                    if (dgvObj_ListDocument.RowCount > DocIndex) dgvObj_ListDocument.CurrentCell = dgvObj_ListDocument["docNumber", DocIndex];


                                    MessageBox.Show("Документ успешно удален");
                                }
                                else
                                {
                                    MessageBox.Show("Документ успешно восстановлен");
                                }
                            }
                            break;

                        case (int)DocType.ActKO:
                        case (int)DocType.ActCheck:
                        case (int)DocType.ActMeterInstallation:
                        case (int)DocType.ActMeterDismantling:
                        case (int)DocType.ActMeterkReplacement:
                            this.SelectSqlData(ds.tDocAct_Check, true, "where id = " + idDoc, null, false, 1);
                            this.SelectSqlData(ds.tDocAct, true, "where id = " + ds.tDocAct_Check.Rows[0]["idDocAct"], null, false, 1);
                            ds.tDocAct.First().Deleted = !ds.tDocAct.First().Deleted;
                            ds.tDocAct.First().EndEdit();
                            if (this.UpdateSqlData(ds, ds.tDocAct))
                            {
                                if (ds.tDocAct.First().Deleted)
                                {
                                    this.SelectSqlData(ds, ds.vAbnObjDoc_List, true, " where idAbnObj = " + idnode.ToString() + " order by DocDate desc");

                                    if (dgvObj_ListDocument.RowCount > DocIndex) dgvObj_ListDocument.CurrentCell = dgvObj_ListDocument["docNumber", DocIndex];


                                    MessageBox.Show("Документ успешно удален");
                                }
                                else
                                {
                                    MessageBox.Show("Документ успешно восстановлен");
                                }
                            }
                            break;
                        #region
                        case (int)TypeCalcLoss.TypeKL:
                        case (int)TypeCalcLoss.TypeVL:
                        case (int)TypeCalcLoss.TypeTrans:
                            if (tsCalcLoss.Enabled)
                            {
                                this.SelectSqlData(ds.tJ_CalcLoss, true, "where id = " + idDoc.ToString());
                                if (ds.tJ_CalcLoss.Rows.Count > 0)
                                {
                                    ds.tJ_CalcLoss.Rows[0]["deleted"] = 1;
                                    ds.tJ_CalcLoss.Rows[0].EndEdit();
                                    if (this.UpdateSqlData(ds, ds.tJ_CalcLoss))
                                    {
                                        this.SelectSqlData(ds, ds.vAbnObjDoc_List, true,
                                            " where idAbnObj = " + idnode.ToString() + " order by DocDate desc");
                                        MessageBox.Show("Документ успешно удален");
                                    }
                                }
                            }
                            break;
                        #endregion
                        default:
                            MessageBox.Show("Невозможно удалить текущий документ");
                            break;

                    } //end switch
                }
            }
            else
            {
                MessageBox.Show("Не выбран документ для удаления");
            }


        }

        private void EditDocObj()
        {
            if (dgvObj_ListDocument.CurrentRow != null)
                switch (Convert.ToInt32(dgvObj_ListDocument.CurrentRow.Cells[idDocType.Name].Value))
                {
                    case (int)DocType.DogovorTransferEnergy:
                        break;
                    case (int)DocType.ActUst:
                        break;
                    case (int)DocType.ActDem:
                        break;
                    case (int)DocType.LossCalculation:
                        break;
                    case (int)DocType.ActPerehod:
                        break;
                    // Акт разграничения балансовой принадлежности
                    case (int)DocType.ActLiability:
                    case (int)DocType.ActRBP:
                        Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP frmAktRBP =
                            new Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP(this.SqlSettings, idnode,
                            Convert.ToInt32(dgvObj_ListDocument.CurrentRow.Cells[idDoc.Name].Value));
                        frmAktRBP.MdiParent = this.MdiParent;
                        frmAktRBP.FormClosed += new FormClosedEventHandler(frmAktRBP_FormClosed);
                        frmAktRBP.Show();
                        break;
                    case (int)DocType.ActTP:
                        break;
                    case (int)DocType.ActKO:
                    case (int)DocType.ActMeterInstallation:
                    case (int)DocType.ActMeterDismantling:
                    case (int)DocType.ActMeterkReplacement:
                    case (int)DocType.ActCheck:
                        Legal.Forms.ActCheck.FormDocAct_CheckAdd frmActCheckAdd = new FormDocAct_CheckAdd(this.SqlSettings, idnode);
                        frmActCheckAdd.Show();
                        break;
                    case (int)DocType.Dogovor:
                        break;
                    case (int)DocType.DogovorEnergo:
                        break;
                    #region Расчет потерь 17.09.2013
                    case (int)TypeCalcLoss.TypeKL:
                    case (int)TypeCalcLoss.TypeVL:
                    case (int)TypeCalcLoss.TypeTrans:
                        if (tsCalcLoss.Enabled)
                            EditCalcLoss();
                        break;
                    #endregion
                    #region акт осмотра эл, выполнения ту, акт о тп
                    case (int)eTypeDocTC.ActTC:
                    case (int)eTypeDocTC.ActElectricalInspection:
                    case (int)eTypeDocTC.ActPerformingTU:
                    case (int)eTypeDocTC.ChangeSwitch:
                        EditActTC();
                        break;
                    #endregion
                    default:
                        break;
                }
        }

        void frmAktRBP_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.SelectSqlData(dsFastTree, dsFastTree.vAbnObjDoc_List, true, " where idAbnObj = " + idnode.ToString() + " order by DocDate desc");
        }

        private void EditCalcLoss()
        {
            if (dgvObj_ListDocument.CurrentRow != null)
            {
                int typeCalc = Convert.ToInt32(dgvObj_ListDocument.CurrentRow.Cells[idDocType.Name].Value);
                int idCalc = Convert.ToInt32(dgvObj_ListDocument.CurrentRow.Cells[idDoc.Name].Value);
                if (typeCalc == (int)Constants.TypeCalcLoss.TypeTrans)
                {
                    FormAddEditCalcTrans f = new FormAddEditCalcTrans(idCalc, typeCalc);
                    f.MdiParent = this.MdiParent;
                    f.SqlSettings = this.SqlSettings;
                    f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                    f.Show();
                }
                else // КЛ/ВЛ
                {
                    FormAddEditCalcCable f = new FormAddEditCalcCable(idCalc, typeCalc);
                    f.MdiParent = this.MdiParent;
                    f.SqlSettings = this.SqlSettings;
                    f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                    f.Show();
                }
            }
        }

        void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (((Form)sender).DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this.SelectSqlData(dsFastTree, dsFastTree.vAbnObjDoc_List, true,
                    " where idAbnObj = " + idnode.ToString() + " order by DocDate desc");
            }
        }

        private void EditActTC()
        {
            if (dgvObj_ListDocument.CurrentRow != null)
            {
                int typeDoc = Convert.ToInt32(dgvObj_ListDocument.CurrentRow.Cells[idDocType.Name].Value);
                int idDocum = Convert.ToInt32(dgvObj_ListDocument.CurrentRow.Cells[idDoc.Name].Value);

                switch (typeDoc)
                {
                    case (int)eTypeDocTC.ActTC:
                        Documents.Forms.TechnologicalConnection.ActTC.FormTCAddEdit fTC =
                            new Documents.Forms.TechnologicalConnection.ActTC.FormTCAddEdit
                                (idDocum);
                        fTC.SqlSettings = this.SqlSettings;
                        fTC.MdiParent = this.MdiParent;
                        fTC.FormClosed += new FormClosedEventHandler(f_FormClosed);
                        fTC.Show();
                        break;
                    case (int)eTypeDocTC.ActPerformingTU:  // акт о выполении ТУ
                        Documents.Forms.TechnologicalConnection.Acts.FormActPerformingTU fPerf =
                            new Documents.Forms.TechnologicalConnection.Acts.FormActPerformingTU(idDocum);
                        fPerf.SqlSettings = this.SqlSettings;
                        fPerf.MdiParent = this.MdiParent;
                        fPerf.FormClosed += new FormClosedEventHandler(f_FormClosed);
                        fPerf.Show();
                        break;
                    case (int)eTypeDocTC.ActElectricalInspection:
                        Documents.Forms.TechnologicalConnection.Acts.FormActElectricalInspection f =
                            new Documents.Forms.TechnologicalConnection.Acts.FormActElectricalInspection(idDocum);
                        f.SqlSettings = this.SqlSettings;
                        f.MdiParent = this.MdiParent;
                        f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                        f.Show();
                        break;
                    case (int)eTypeDocTC.ChangeSwitch:
                        Documents.Forms.TechnologicalConnection.Rebinding.FormDocChangeSwitch fChangeSwitch =
                            new Documents.Forms.TechnologicalConnection.Rebinding.FormDocChangeSwitch(idDocum);
                        fChangeSwitch.SqlSettings = this.SqlSettings;
                        fChangeSwitch.MdiParent = this.MdiParent;
                        fChangeSwitch.FormClosed += new FormClosedEventHandler(f_FormClosed);
                        fChangeSwitch.Show();
                        break;
                }
            }
        }

        private void ReportActTC()
        {
            if (dgvObj_ListDocument.CurrentRow != null)
            {
                int idDocum = Convert.ToInt32(dgvObj_ListDocument.CurrentRow.Cells[idDoc.Name].Value);
                int typeDoc = Convert.ToInt32(dgvObj_ListDocument.CurrentRow.Cells[idDocType.Name].Value);

                switch (typeDoc)
                {
                    case (int)eTypeDocTC.ActTC:
                    case (int)eTypeDocTC.ActPerformingTU:  // акт о выполении ТУ
                    case (int)eTypeDocTC.ActElectricalInspection:
                        Documents.Forms.TechnologicalConnection.Acts.FormReportActElectricalInspection f =
                           new Documents.Forms.TechnologicalConnection.Acts.FormReportActElectricalInspection(idDocum);
                        f.SqlSettings = this.SqlSettings;
                        f.MdiParent = this.MdiParent;
                        f.Show();
                        break;
                    case (int)eTypeDocTC.ChangeSwitch:
                        Documents.Forms.TechnologicalConnection.Rebinding.FormDocChangeSwitch fChSw =
                            new Documents.Forms.TechnologicalConnection.Rebinding.FormDocChangeSwitch(idDocum, true);
                        fChSw.SqlSettings = this.SqlSettings;
                        fChSw.MdiParent = this.MdiParent;
                        fChSw.Show();
                        break;
                }
            }
        }

        private void ReportCalcLoss()
        {
            if (dgvObj_ListDocument.CurrentRow != null)
            {
                int idCalc = Convert.ToInt32(dgvObj_ListDocument.CurrentRow.Cells[idDoc.Name].Value);
                if (Convert.ToInt32(dgvObj_ListDocument.CurrentRow.Cells[idDocType.Name].Value) ==
                    (int)Constants.TypeCalcLoss.TypeTrans)
                {
                    Documents.Forms.JournalCalcLoss.Report.FormReportCalcLossTrans f = new Documents.Forms.JournalCalcLoss.Report.FormReportCalcLossTrans(idCalc);
                    f.MdiParent = this.MdiParent;
                    f.SqlSettings = this.SqlSettings;
                    f.Show();
                }
                else
                {
                    Documents.Forms.JournalCalcLoss.Report.FormReportCalcLoss f = new Documents.Forms.JournalCalcLoss.Report.FormReportCalcLoss(idCalc);
                    f.MdiParent = this.MdiParent;
                    f.SqlSettings = this.SqlSettings;
                    f.Show();
                }
            }
        }

        private void tsActBal_Click(object sender, EventArgs e)
        {
            int idAbn = Convert.ToInt32(dsFastTree.vMap_FastTree_AbnObjMeter.Rows[0]["idAbn"].ToString());
            Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP frmAktRBP =
                new Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP(this.SqlSettings, false, true,
                    idAbn, idnode, TypeDocValue.ActBalance);
            frmAktRBP.MdiParent = this.MdiParent;
            frmAktRBP.FormClosed += new FormClosedEventHandler(frmAktRBP_FormClosed);
            frmAktRBP.Show();
        }

        private void tsAct_Click(object sender, EventArgs e)
        {
            int idAbn = Convert.ToInt32(dsFastTree.vMap_FastTree_AbnObjMeter.Rows[0]["idAbn"].ToString());
            Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP frmAktRBP =
                new Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP(this.SqlSettings, false, true,
                    idAbn, idnode, TypeDocValue.ActLiability);
            frmAktRBP.MdiParent = this.MdiParent;
            frmAktRBP.FormClosed += new FormClosedEventHandler(frmAktRBP_FormClosed);
            frmAktRBP.Show();
        }

        private void tsActCheck_Click(object sender, EventArgs e)
        {
            if (dgvObj_ListMeter.RowCount > 0)
            {
                FormDocAct_CheckAdd frmActCheckAdd = new FormDocAct_CheckAdd(this.SqlSettings, idnode);
                frmActCheckAdd.Show();
            }
        }

        private void tsCalcLoss_Click(object sender, EventArgs e)
        {

        }

        #endregion

        // привязка объектов
        private void UpdateSchmLink()
        {
            // теперь получаем данные по привязкам объектов

            this.SelectSqlData(dsFastTree, dsFastTree.vL_SchmAbn, true, " where idAbnObj = " + idnode + " order by SchmObjName ");

            int idSchmObj = 0;
            int idAbnObj = 0;
            string StrLink = null;
            string str = "";

            foreach (DataRow row in dsFastTree.vL_SchmAbn.Rows)
            {
                str = "";
                idAbnObj = Convert.ToInt32(row["idAbnObj"]);
                StrLink = (row["idSchmObj"]).ToString();
                try
                {
                    if (int.TryParse(StrLink, out idSchmObj))
                    {
                        //центр питания
                        var listSchmObj = electricModel.GetCellCP((int)idSchmObj);
                        if (listSchmObj != null)
                            if (listSchmObj.Length > 0)
                            {
                                if (listSchmObj[0].ElectricSubName != null)
                                    str += listSchmObj[0].ElectricSubName + "/ ";
                                if (listSchmObj[0].electricLine != null)
                                    str += listSchmObj[0].electricLine.ToString() + "/ ";
                            }
                        var ElectricObject = electricModel.GetElectricObjectById((int)idSchmObj);
                        str += ElectricObject.FullName.ToString();
                    }
                }
                catch (Exception ex)
                {
                    str = "Извините, данные неверны..";
                    //MessageBox.Show(ex.ToString() + ": " + idSchmObj.ToString(), "Ошибка", MessageBoxButtons.OK);
                }
                row["ShemeObjNameAll"] = str;
            }
            dgvObj_LinkSchm.Columns["ShemeObjNameAll"].Visible = true;
        }

        # endregion

        # region вкладка Прибор учета

        private void dgv_MeterVolume_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0)
                return;
            if (IsRepeatedCellValue2(e.RowIndex, e.ColumnIndex))
            {
                if (e.ColumnIndex == 0)
                {
                    e.Value = string.Empty;
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgv_MeterVolume_CellPainting(object sender, DataGridViewCellPaintingEventArgs args)
        {
            if (args.ColumnIndex == 0)
                args.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            // Ignore column and row headers and first row
            if (args.RowIndex < 1 || args.ColumnIndex < 0)
                return;
            if (IsRepeatedCellValue2(args.RowIndex, args.ColumnIndex))
            {
                if (args.ColumnIndex == 0)
                    args.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
                args.AdvancedBorderStyle.Top = args.AdvancedBorderStyle.Top;
            }
        }

        private bool IsRepeatedCellValue2(int rowIndex, int colIndex)
        {
            DataGridViewCell currCell = dgv_MeterVolume.Rows[rowIndex].Cells[colIndex];
            DataGridViewCell prevCell = dgv_MeterVolume.Rows[rowIndex - 1].Cells[colIndex];

            if ((currCell.Value == prevCell.Value) ||
                (currCell.Value != null && prevCell.Value != null &&
                currCell.Value.ToString() == prevCell.Value.ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void dgvMeter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // показания
            dsFastTree.vF_MeterValAll.Rows.Clear();
            int idPointReg = Convert.ToInt32(dgvMeter.CurrentRow.Cells["meterID"].Value);
            this.SelectSqlData(dsFastTree, dsFastTree.vF_MeterValAll, true, " where MeterID = " + idPointReg + " order by YearCalc asc, MonthCalc asc");
            // заполним выпадающий список годами начислений 

        }

        # endregion

        # endregion

        # region форма баланса

        private class linkAbnObjScmhObj : CenterPower
        {
            public string TPName;
            public string CellTPName;
            public int idSchmObj;
        }
        private class CenterPower
        {
            public string CPName;
            public string CellCPName;
            public int idCP;
            public int idCellCP;
            public int idStation;
        }

        private void btnOKBalance_Click(object sender, EventArgs e)
        {
            FillReport();

            foreach (DataRow row in dsFastTree.tG_ReportMain_Link3.Rows)
            {
                if (row["CPName"] == DBNull.Value)
                    row["CPName"] = "no";
                if (row["CellCPName"] == DBNull.Value)
                    row["CellCPName"] = "no";
                if (row["TP"] == DBNull.Value)
                    row["TP"] = "no";
                if (row["idCP"] == DBNull.Value)
                    row["idCP"] = 1;
                if (row["idCellCP"] == DBNull.Value)
                    row["idCellCP"] = 1;
                if (row["idStation"] == DBNull.Value)
                    row["idStation"] = 1;
            }

            //BindingSource bds = new BindingSource();
            //bds.DataSource = dsFastTree.tG_ReportMain_Link3;
            //dgvBalance.AutoGenerateColumns = true;
            //dgvBalance.DataSource = bds;

            var groupQuantity =
              dsFastTree.tG_ReportMain_Link3
              .GroupBy(r => new { r.CPName, r.idCP, r.CellCPName, r.idCellCP, r.TP, r.idStation })
              .Select(g => new
              {
                  CPName = g.Key.CPName,
                  idCP = g.Key.idCP,
                  CellCPName = g.Key.CellCPName,
                  idCellCP = g.Key.idCellCP,
                  Station = g.Key.TP,
                  idStation = g.Key.idStation,
                  Total = g.Sum(r => r.Quantity)
              });


            #region готовим таблицу для грида
            idnode = 1;

            var flat = root2.Childs.SelectNestedChildren(t => t.Childs).ToList();
            DataTable dt = new DataTable("dtBalance");

            dt.Columns.Add(new DataColumn("Center", typeof(string)));
            dt.Columns.Add(new DataColumn("Cell", typeof(string)));
            dt.Columns.Add(new DataColumn("Substation", typeof(string)));
            dt.Columns.Add(new DataColumn("InputVolume", typeof(int)));
            dt.Columns.Add(new DataColumn("OutputVolume", typeof(int)));
            dt.Columns.Add(new DataColumn("DifferVolume", typeof(int)));
            dt.Columns.Add(new DataColumn("PercentVolume", typeof(decimal)));

            dsFastTree.Tables.Add(dt);
            BindingSource bds = new BindingSource();
            bds.DataSource = dt;

            DataGridViewColumn Center = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            Center.Name = "Center";

            DataGridViewColumn Cell = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            Cell.Name = "Cell";

            DataGridViewColumn Substation = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            Substation.Name = "Substation";

            DataGridViewColumn InputVolume = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            InputVolume.Name = "InputVolume";

            DataGridViewColumn OutputVolume = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            OutputVolume.Name = "OutputVolume";

            DataGridViewColumn DifferVolume = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            DifferVolume.Name = "DifferVolume";

            DataGridViewColumn PercentVolume = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            PercentVolume.Name = "PercentVolume";

            DataGridViewCellStyle IntStyle = new DataGridViewCellStyle();
            IntStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            IntStyle.Format = "N0";

            DataGridViewCellStyle StringStyle = new DataGridViewCellStyle();
            StringStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DataGridViewCellStyle DecStyle = new DataGridViewCellStyle();
            DecStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DecStyle.Format = "N2";

            DataGridViewCellStyle DecStyle6 = new DataGridViewCellStyle();
            DecStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            DecStyle6.Format = "N6";

            dgvBalance.Columns.Add(Center);
            dgvBalance.Columns.Add(Cell);
            dgvBalance.Columns.Add(Substation);
            dgvBalance.Columns.Add(InputVolume);
            dgvBalance.Columns.Add(OutputVolume);
            dgvBalance.Columns.Add(DifferVolume);
            dgvBalance.Columns.Add(PercentVolume);

            dgvBalance.Columns["Center"].Width = 300;
            dgvBalance.Columns["Center"].HeaderText = "Центр питания";
            dgvBalance.Columns["Center"].ValueType = typeof(string);
            dgvBalance.Columns["Center"].DefaultCellStyle = StringStyle;
            dgvBalance.Columns["Center"].DataPropertyName = "Center";

            dgvBalance.Columns["Cell"].Width = 100;
            dgvBalance.Columns["Cell"].HeaderText = "Ячейка";
            dgvBalance.Columns["Cell"].ValueType = typeof(string);
            dgvBalance.Columns["Cell"].DefaultCellStyle = StringStyle;
            dgvBalance.Columns["Cell"].DataPropertyName = "Cell";

            dgvBalance.Columns["Substation"].Width = 100;
            dgvBalance.Columns["Substation"].HeaderText = "Подстанция";
            dgvBalance.Columns["Substation"].ValueType = typeof(string);
            dgvBalance.Columns["Substation"].DefaultCellStyle = StringStyle;
            dgvBalance.Columns["Substation"].DataPropertyName = "Substation";

            dgvBalance.Columns["InputVolume"].Width = 120;
            dgvBalance.Columns["InputVolume"].HeaderText = "Поступление, кВт*ч";
            dgvBalance.Columns["InputVolume"].ValueType = typeof(int);
            dgvBalance.Columns["InputVolume"].DefaultCellStyle = IntStyle;
            dgvBalance.Columns["InputVolume"].DataPropertyName = "InputVolume";

            dgvBalance.Columns["OutputVolume"].Width = 120;
            dgvBalance.Columns["OutputVolume"].HeaderText = "Отпуск, кВт*ч";
            dgvBalance.Columns["OutputVolume"].ValueType = typeof(int);
            dgvBalance.Columns["OutputVolume"].DefaultCellStyle = IntStyle;
            dgvBalance.Columns["OutputVolume"].DataPropertyName = "OutputVolume";

            dgvBalance.Columns["DifferVolume"].Width = 120;
            dgvBalance.Columns["DifferVolume"].HeaderText = "Небаланс, кВт*ч";
            dgvBalance.Columns["DifferVolume"].ValueType = typeof(int);
            dgvBalance.Columns["DifferVolume"].DefaultCellStyle = IntStyle;
            dgvBalance.Columns["DifferVolume"].DataPropertyName = "DifferVolume";

            dgvBalance.Columns["PercentVolume"].Width = 120;
            dgvBalance.Columns["PercentVolume"].HeaderText = "Небаланс, %";
            dgvBalance.Columns["PercentVolume"].ValueType = typeof(int);
            dgvBalance.Columns["PercentVolume"].DefaultCellStyle = DecStyle;
            dgvBalance.Columns["PercentVolume"].DataPropertyName = "PercentVolume";

            // назначим источник данных грида
            dgvBalance.AutoGenerateColumns = false;
            dgvBalance.DataSource = bds;

            dt.Clear();
            string center = "";
            string cell = "";
            int idCenter = 0;
            int cntCell = 0;
            int idCell = 0;

            // объем поступления
            int inputVolume = 0;
            int outputVolume = 0;
            int outputVolumeSum = 0;
            int inpTotal = 0;
            int outTotal = 0;

            # endregion

            #region заполняем ее данными
            foreach (var item in flat)
            {

                DataRow rw = dt.NewRow();
                switch (item.Level)
                {
                    case "Центр":
                    if (dt.Rows.Count > 0)
                    {
                        // Итоги по ячейке ЦП
                        DataRow rw2 = dt.NewRow();
                        inputVolume = volumeCenterCell(item.idNode);
                        rw2["Center"] = "Всего по ячейке";
                        rw2["Cell"] = cell;
                        rw2["Substation"] = "";
                        rw2["InputVolume"] = inputVolume;
                        rw2["OutputVolume"] = outputVolumeSum;
                        rw2["DifferVolume"] = inputVolume - outputVolumeSum;
                        if (inputVolume != 0)
                            rw2["PercentVolume"] = (inputVolume - outputVolumeSum) * 100 / inputVolume;
                        else
                            rw2["PercentVolume"] = 0;
                        dt.Rows.Add(rw2);
                        inpTotal += inputVolume;
                        outputVolumeSum = 0;

                        // Итоги по ЦП
                        rw["Center"] = "Всего по " + center;
                        rw["Cell"] = "";
                        rw["Substation"] = "";
                        rw["InputVolume"] = inpTotal;
                        rw["OutputVolume"] = outTotal;
                        rw["DifferVolume"] = inpTotal - outTotal;
                        if (inpTotal != 0)
                            rw["PercentVolume"] = (inpTotal - outTotal) * 100 / inpTotal;
                        else
                            rw["PercentVolume"] = 0;
                        dt.Rows.Add(rw);
                        inpTotal = 0;
                        outTotal = 0;
                    }

                        center = item.Title;
                        idCenter = item.idNode;
                        cntCell = 0;
                        break;
                    case "Ячейка ЦП":

                        if (cntCell > 0)
                        {
                        // Итоги по ячейке ЦП
                            inputVolume = volumeCenterCell(idCell);
                            rw["Center"] = "Всего по ячейке";
                            rw["Cell"] = cell;
                            rw["Substation"] = "";
                            rw["InputVolume"] = inputVolume;
                            rw["OutputVolume"] = outputVolumeSum;
                            rw["DifferVolume"] = inputVolume - outputVolumeSum;
                            if (inputVolume != 0)
                                rw["PercentVolume"] = (inputVolume - outputVolumeSum) * 100 / inputVolume;
                            else
                                rw["PercentVolume"] = 0;
                            dt.Rows.Add(rw);
                            inpTotal += inputVolume;
                            outputVolumeSum = 0;
                        }
                        
                        cell = item.Title;
                        station = new List<string> { };
                        idCell = item.idNode;
                        cntCell++;
                        break;
                    case "substation":
                        if (station.IndexOf(item.Title) == -1)
                        {
                            rw["Center"] = center;
                            rw["Cell"] = cell;
                            rw["Substation"] = item.Title;

                            outputVolume = 0;
                            foreach (var el in groupQuantity)
                            {
                                if (el.idCP == idCenter && el.idCellCP == idCell && el.idStation == item.idNode)
                                    outputVolume += el.Total;
                                else
                                {
                                    if (el.CPName.ToUpper().Trim() == center.ToUpper().Trim()
                                        && el.CellCPName.ToUpper().Trim() == cell.ToUpper().Trim()
                                        && el.Station.ToUpper().Trim().EndsWith(item.Title.ToUpper().Trim()))

                                        outputVolume += el.Total;
                                }

                            }

                            rw["OutputVolume"] = outputVolume;
                            // суммируем отпуск по каждой подстанции
                            outputVolumeSum += outputVolume;
                            outTotal += outputVolume; 
                            dt.Rows.Add(rw);
                        }
                        station.Add(item.Title);
                        break;
                }
            }
            #endregion 
 
        }
        private void FillReport()
        {
            #region получаем данные по начислениям
            dsFastTree.tG_ReportMain_Link.Rows.Clear();
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);
                string strCmd = "";

                strCmd = "select idAbnObj,dtPay,Quantity,idSchmObj from [fn_LegReportMain_Link-3](@DateBegin, @DateEnd) order by codeabonent";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                DateTime DateBegin = (DateTime)dtBegin.Value.Date;
                DateTime DateEnd = (DateTime)dtEnd.Value.Date;

                SqlParameter p1 = new SqlParameter("@DateBegin", DateBegin.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@DateEnd", DateEnd.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p2);

                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsFastTree, "tG_ReportMain_Link3");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.CloseConnection();
            }
            #endregion

            #region теперь получаем данные по привязкам объектов
            int? idSchmObj = null;
            int idAbnObj = 0;
            DateTime? dtPay = null;
            //            int row_number = 1;
            int? StationID = null;

            // список точек привязки к центрам питания
            Dictionary<int, CenterPower> listSchmPointCP = new Dictionary<int, CenterPower>();
            // список объектов с привязкой к объекту схемы
            Dictionary<int, linkAbnObjScmhObj> listAbnObjScmhObjLink = new Dictionary<int, linkAbnObjScmhObj>();

            foreach (DataRow row in dsFastTree.tG_ReportMain_Link3.Rows)
            {

                if (idAbnObj == Convert.ToInt32(row["idAbnObj"]) && dtPay == Convert.ToDateTime(row["dtPay"]))
                {
                    row["Quantity"] = 0;
                    //                    row_number = row_number + 1;
                }
                else
                {
                    idAbnObj = Convert.ToInt32(row["idAbnObj"]);
                    dtPay = Convert.ToDateTime(row["dtPay"]);
                    //                    row_number = 1;
                }
                //                row["rowSubAbnObj"] = row_number;
                try
                {
                    if (row["idSchmObj"] != DBNull.Value)
                    {
                        idSchmObj = (int)row["idSchmObj"];
                        var ElectricObject = electricModel.GetParamsElectricObjectById((int)idSchmObj);
                        row["TP"] = ElectricObject.ElectricSubName;

                        if (ElectricObject.electricObject != null)
                            row["idStation"] = ElectricObject.electricSub.Id;

                        if (ElectricObject.electricObject is SchemeModelN.ElectricLine)
                        {
                            row["TPCell"] = ElectricObject.electricLine.ToString();
                        }
                        if (ElectricObject.electricObject != null)
                        {
                            // если привязка была, то ищем ее в списке
                            var centerPower = listSchmPointCP.Where(w => w.Key == ElectricObject.electricObject.Id);
                            if (centerPower != null && centerPower.Count() > 0)
                            {
                                row["CPName"] = centerPower.First().Value.CPName;
                                row["CellCPName"] = centerPower.First().Value.CellCPName;
                                row["idCP"] = centerPower.First().Value.idCP;
                                row["idCellCP"] = centerPower.First().Value.idCellCP;

                            }
                            else // ищем центр питания по объекту схему
                            {
                                var listSchmObj = electricModel.GetCellCP((int)idSchmObj);
                                if (listSchmObj != null)
                                    if (listSchmObj.Length > 0)
                                    {
                                        if (listSchmObj[0].ElectricSubName != null)
                                        {
                                            row["CPName"] = listSchmObj[0].electricSub;
                                            row["idCP"] = listSchmObj[0].electricSub.Id;
                                        }
                                        if (listSchmObj[0].electricLine != null)
                                        {
                                            row["CellCPName"] = listSchmObj[0].electricLine.ToString();
                                            row["idCellCP"] = listSchmObj[0].electricLine.Id;
                                        }
                                    }
                                // добавляем в список привязки объекта схемы к центру питания

                                int idCP2 = (row["idCP"] == DBNull.Value ? 0 : Convert.ToInt32(row["idCP"]));
                                int idCellCP2 = (row["idCellCP"] == DBNull.Value ? 0 : Convert.ToInt32(row["idCellCP"]));

                                listSchmPointCP.Add(ElectricObject.electricObject.Id, new CenterPower
                                {
                                    CPName = row["CPName"].ToString(),
                                    idCP = idCP2,
                                    CellCPName = row["CellCPName"].ToString(),
                                    idCellCP = idCellCP2
                                });

                                // добавим в список привязку объекта абонента к объекту схемы
                                var AbnObjScmhObjLink = listAbnObjScmhObjLink.Where(w => w.Key == ElectricObject.electricObject.Id);
                                if (AbnObjScmhObjLink != null && AbnObjScmhObjLink.Count() > 0)
                                    listAbnObjScmhObjLink.Add(idAbnObj, new linkAbnObjScmhObj
                                    {
                                        idSchmObj = ElectricObject.electricObject.Id,
                                        TPName = row["TP"].ToString(),
                                        CellTPName = row["TPCell"].ToString(),
                                        CPName = row["CPName"].ToString(),
                                        idCP = idCP2,
                                        CellCPName = row["CellCPName"].ToString(),
                                        idCellCP = idCellCP2
                                    });
                            }
                        }
                    }
                    else // привязки к схеме нет
                    {
                        // если объект абонента есть, то можно найти привязку в схеме (если есть)
                        var linkSchmObj = listAbnObjScmhObjLink.Where(w => w.Key == idAbnObj);
                        if (linkSchmObj != null && linkSchmObj.Count() > 0)
                        {
                            row["CPName"] = linkSchmObj.First().Value.CPName;
                            row["CellCPName"] = linkSchmObj.First().Value.CellCPName;
                            row["TP"] = linkSchmObj.First().Value.TPName; ;
                            row["TPCell"] = linkSchmObj.First().Value.CellTPName;
                            row["idSchmObj"] = linkSchmObj.First().Value.idSchmObj;
                            row["idCP"] = linkSchmObj.First().Value.idCP;
                            row["idCellCP"] = linkSchmObj.First().Value.idCellCP;
                        }
                    }
                    if (row["Quantity"] == System.DBNull.Value)
                        row["Quantity"] = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + ": " + idSchmObj.ToString(), "Ошибка", MessageBoxButtons.OK);
                }
            }
            #endregion
        }
        // берем объемы по ячейке центра питания
        private int volumeCenterCell(int id)
        {
            string txtWhere = " and (dtPay >= '" + dtBegin.Value.Date.ToString("yyyyMMdd") + "') and " +
            " (dtPay <= '" + dtEnd.Value.Date.ToString("yyyyMMdd") + "') ";

            this.SelectSqlData(dsFastTree, dsFastTree.vG_BalanceEnterVolume, true, "where idLink = " + id + txtWhere);
            if (dsFastTree.vG_BalanceEnterVolume.Rows.Count > 0)
                return Convert.ToInt32(dsFastTree.vG_BalanceEnterVolume.Rows[0]["inputVolume"]);
            else
                return 0;
        }
        // собираем объем по всем контрагентам подстанции
        private int volumeSubstation(int id, string center, string cell, string station)
        {

            DataTable dt = dsFastTree.tG_ReportMain_Link;
            var data = dsFastTree.tG_ReportMain_Link.Where(d =>
                (d.CPName.Contains(center) && d.CellCPName.Contains(cell)));
            var sumQuantity = data.Sum(d => d.Quantity);

            // находим всех контрагентов подключенных к подстанции
            GetListAbnObj_LinqSub(1, id);

            // по каждому контрагенту находим объем в цикле
            //int idObj = 0;
            //int sumQuantity = 0;
            //if (dsFastTree.vL_SchmAbnFull_2020.Rows.Count > 0)
            //    for (int i = 0; i < dsFastTree.vL_SchmAbnFull_2020.Rows.Count; i++)
            //    {
            //        idObj = Convert.ToInt32(dsFastTree.vL_SchmAbnFull_2020.Rows[i]["idAbnObj"]);
            //        SelectSqlData(dsFastTree, dsFastTree.vG_ObjVolume, true, " where idAbnObj = " + idObj);
            //        if (dsFastTree.vG_ObjVolume.Rows.Count > 0)
            //            sumQuantity += Convert.ToInt32(dsFastTree.vG_ObjVolume.Rows[0]["Quantity"]);
            //    }
            return sumQuantity;
        }

        private void btnPlus_Click_1(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddMonths(1);
            dtEnd.Value = dtEnd.Value.AddDays(1).AddMonths(1).AddDays(-1);
        }
        private void btnMinus_Click_1(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddMonths(-1);
            dtEnd.Value = dtEnd.Value.AddDays(1).AddMonths(-1).AddDays(-1);
        }

        private void btnExcelBalance_Click_1(object sender, EventArgs e)
        {
            dgvBalance.ExportToExcel();
        }
        private void btnExportExcel2_Click(object sender, EventArgs e)
        {
            if (tabControlTree.SelectedIndex != 1)
            {
                MessageBox.Show("Экспорт в Excel только для дерева подстанций!");
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            // добавляем книгу и лист
            xlApp = new Excel.ApplicationClass();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            // обход дерева в глубину
            var flat = root2.Childs.SelectNestedChildren(t => t.Childs).ToList();

            // здесь будем хранить номера столбцов для отступа новой ветки 
            Stack<int> stack = new Stack<int>();

            int i = 1; // строка
            int j = 1; // столбец
            foreach (var item in flat)
            {
                // питающий центр новой строки
                if (item.Level == "Центр")
                {
                    j = 1;
                    i++;
                }
                if (item.Level == "Ячейка ЦП")
                {
                    j = 2;
                    i++;
                }
                // запомним номер столбца с которого будет начинаться новая ветка на след строке 
                if (item.Childs.Count > 1)
                    stack.Push(j);
                xlWorkSheet.Cells[i, j] = item.Title;
                // деток нет ветка закончилась
                if (item.Childs.Count == 0)
                {
                    // если стэк не пустой достаем верхний элемент с номером столбца и
                    // переходим на него в новой строке(новая строка)
                    if (stack.Count != 0)
                        j = stack.Pop();
                    else
                        j = 1;
                    i++;
                }
                j++;
            }
            this.Cursor = Cursors.Default;
            xlApp.Visible = true;

        }

        // перейти к форме баланса
        private void tsbBalans_Click(object sender, EventArgs e)
        {
            level = "balance";
            tch2.ChangePage(level);
            statusAbn.Text = "";
            //this.statusAbn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }
        private void dgvBalance_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < dgvBalance.RowCount)
            {
                if (dgvBalance.Rows[e.RowIndex].Cells["Center"].Value.ToString().Contains("Всего по"))
                    ((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.Font = new Font(dgvBalance.DefaultCellStyle.Font, FontStyle.Bold); ;
            }

        }

        # endregion

        # region разные примеры

        // пример обхода дерева
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            string _out = "";

            TV solution = new TV();
            TV.Node root = new TV.Node(1);

            root.children.Add(new TV.Node(3));
            root.children.Add(new TV.Node(2));
            root.children.Add(new TV.Node(4));

            root.children[0].children.Add(new TV.Node(5));
            root.children[0].children.Add(new TV.Node(6));

            _out = ("[");

            List<int> temp = solution.postorder(root);

            int size = temp.Count;
            int count = 0;

            foreach (int v in temp)
            {
                _out = _out + " " + v;
                count++;
                if (count < size)
                    _out = _out + (", ");
            }
            _out = _out + "]";
            txt.Text = _out;
        }

        // дерево Кириллова
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SchemeReports.FormTreeSchmObj frm = new SchemeReports.FormTreeSchmObj();
            frm.SqlSettings = this.SqlSettings;
            frm.ShowDialog();

        }

        // вывод в Excel дерева подстанций для формы Спасова
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (tabControlTree.SelectedIndex != 1)
            {
                MessageBox.Show("Экспорт в Excel только для дерева подстанций!");
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            // добавляем книгу и лист
            xlApp = new Excel.ApplicationClass();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            // обход дерева в глубину
            var flat = root2.Childs.SelectNestedChildren(t => t.Childs).ToList();

            // здесь будем хранить номера столбцов для отступа новой ветки 
            Stack<int> stack = new Stack<int>();

            int i = 1; // строка
            int j = 1; // столбец
            foreach (var item in flat)
            {
                // питающий центр новой строки
                if (item.Level == "Центр")
                {
                    j = 1;
                    i++;
                }
                if (item.Level == "Ячейка ЦП")
                {
                    j = 2;
                    i++;
                }
                // запомним номер столбца с которого будет начинаться новая ветка на след строке 
                if (item.Childs.Count > 1)
                    stack.Push(j);
                xlWorkSheet.Cells[i, j] = item.Title;
                // деток нет ветка закончилась
                if (item.Childs.Count == 0)
                {
                    // если стэк не пустой достаем верхний элемент с номером столбца и
                    // переходим на него в новой строке(новая строка)
                    if (stack.Count != 0)
                        j = stack.Pop();
                    else
                        j = 1;
                    i++;
                }
                j++;
            }
            this.Cursor = Cursors.Default;
            xlApp.Visible = true;
        }

        // вывод в Excel дерева подстанций для формы Богуновой
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (tabControlTree.SelectedIndex != 1)
            {
                MessageBox.Show("Экспорт в Excel только для дерева подстанций!");
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            // добавляем книгу и лист
            xlApp = new Excel.ApplicationClass();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            // обход дерева в глубину
            var flat = root2.Childs.SelectNestedChildren(t => t.Childs).ToList();

            int i = 1; // строка
            int j = 1; // столбец
            foreach (var item in flat)
            {
                if (item.Level == "Центр" || item.Level == "Ячейка ЦП")
                {
                    xlWorkSheet.Cells[i, 1] = item.Title;
                    i++;
                }
                if (item.Level == "substation")
                {
                    xlWorkSheet.Cells[i, 2] = item.Title;
                    i++;
                }
            }
            this.Cursor = Cursors.Default;
            xlApp.Visible = true;

        }

        # endregion

        private void dgvSubStation_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgvSubStation.Rows[e.RowIndex].Cells["busname"].Value.ToString() == "")
                ((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Blue ;
            else
            {
                if (dgvSubStation.Rows[e.RowIndex].Cells["cellname"].Value.ToString() == "")
                    ((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Blue;
            }
        }

        private void dgvSubStation_Person_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgvSubStation_Person.Rows[e.RowIndex].Cells["busname_Person"].Value.ToString() == "")
                ((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Blue;
            else
            {
                if (dgvSubStation_Person.Rows[e.RowIndex].Cells["cellname_Person"].Value.ToString() == "")
                    ((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Blue;
            }
        }

    }
}

