using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Bellus
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            try
            {
                ConnectToDB();
                InitializeComponent();
                Fill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Properties.Settings.Default["ARM_MRKConnectionString"].ToString());
                this.Close();
            }

        }
        private void ConnectToDB()
        {
            using (var connect = new Connect())
            {
                if (connect.ShowDialog() == DialogResult.OK)
                {

                }
                else
                {

                }
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.Addresses". При необходимости она может быть перемещена или удалена.
        }
        private void Fill()
        {
            this.inventoryTableAdapter.Fill(this.mainDataSet.Inventory);
            this.vW_EmployesTableAdapter.Fill(this.mainDataSet.VW_Employes);
            this.typesEmployesTableAdapter.Fill(this.mainDataSet.TypesEmployes);
            this.vW_InventoryTableAdapter.Fill(this.mainDataSet.VW_Inventory);
            this.typesEmployesTableAdapter.Fill(this.mainDataSet.TypesEmployes);
            this.vW_RoomsTableAdapter.Fill(this.mainDataSet.VW_Rooms);
            this.vW_SoftTableAdapter.Fill(this.mainDataSet.VW_Soft);
            this.employesTableAdapter.Fill(this.mainDataSet.Employes);
            this.typesRoomsTableAdapter.Fill(this.mainDataSet.TypesRooms);
            this.roomsTableAdapter.Fill(this.mainDataSet.Rooms);
            this.softsTableAdapter.Fill(this.mainDataSet.Softs);
            this.typesInventoryTableAdapter.Fill(this.mainDataSet.TypesInventory);
            this.addressesTableAdapter.Fill(this.mainDataSet.Addresses);
        }


        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (navigationPane.SelectedPage == navigationPage1)
                {
                    //создание сотрудника
                    using (var employe = new Employee())
                    {
                        if (employe.ShowDialog() == DialogResult.OK)
                        {
                            Fill();
                        }
                    }
                }
                if (navigationPane.SelectedPage == navigationPage2)
                {
                    //создание инвентаря
                    using (var inventory = new Inventory())
                    {
                        if (inventory.ShowDialog() == DialogResult.OK)
                        {
                            Fill();
                        }
                    }
                }
                if (navigationPane.SelectedPage == navigationPage3)
                {
                    //создание софта
                    using (var soft = new Soft())
                    {
                        if (soft.ShowDialog() == DialogResult.OK)
                        {
                            Fill();
                        }
                    }
                }
                if (navigationPane.SelectedPage == navigationPage4)
                {
                    //создание помещения
                    using (var room = new Room())
                    {
                        if (room.ShowDialog() == DialogResult.OK)
                        {
                            Fill();
                        }
                    }
                }
                if (navigationPane.SelectedPage == navigationPage5)
                {
                    if (navigationPane.SelectedPage == navigationPage5)
                    {
                        if (tabPane2.SelectedPage == tabNavigationPage5)
                            //редактирование списка типов сотрудников(новый тип)
                            using (var employeetype = new TypesForms.EmployeeType())
                            {
                                if (employeetype.ShowDialog() == DialogResult.OK)
                                {
                                    Fill();
                                }
                            }
                    }
                    if (tabPane2.SelectedPage == tabNavigationPage6)
                    {
                        //редактирование списка типов ивентаря(новый тип)
                        using (var inventory = new InventoryAdd())
                        {
                            if (inventory.ShowDialog() == DialogResult.OK)
                            {
                                Fill();
                            }
                        }
                    }
                    if (tabPane2.SelectedPage == tabNavigationPage7)
                    {
                        //редактирование списка типов помещений(новый тип)
                        using (var roms = new TypesForms.RoomsType())
                        {
                            if (roms.ShowDialog() == DialogResult.OK)
                            {
                                Fill();
                            }
                        }
                    }
                    if (tabPane2.SelectedPage == tabNavigationPage8)
                    {
                        //редактирование списка адресов(новый адрес)
                        using (var adressees = new TypesForms.AdressesAdd())
                        {
                            if (adressees.ShowDialog() == DialogResult.OK)
                            {
                                Fill();
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Возникло сиситемное исключение, возможно у вас не достаточно прав для этого действия");
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (navigationPane.SelectedPage == navigationPage1)
            {
                var sfd = new SaveFileDialog() { Filter = "Excel file | *xlsx;" };
                if (sfd.ShowDialog() != DialogResult.OK) return;
                gridControlEmployes.ExportToXlsx(sfd.FileName + ".xlsx");
            }
            if (navigationPane.SelectedPage == navigationPage2)
            {
                var sfd = new SaveFileDialog() { Filter = "Excel file | *xlsx;" };
                if (sfd.ShowDialog() != DialogResult.OK) return;
                gridControlInventory.ExportToXlsx(sfd.FileName + ".xlsx");
            }
            if (navigationPane.SelectedPage == navigationPage3)
            {
                var sfd = new SaveFileDialog() { Filter = "Excel file | *xlsx;" };
                if (sfd.ShowDialog() != DialogResult.OK) return;
                gridControlSoft.ExportToXlsx(sfd.FileName + ".xlsx");
            }
            if (navigationPane.SelectedPage == navigationPage4)
            {
                var sfd = new SaveFileDialog() { Filter = "Excel file | *xlsx;" };
                if (sfd.ShowDialog() != DialogResult.OK) return;
                gridControlRooms.ExportToXlsx(sfd.FileName + ".xlsx");
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (navigationPane.SelectedPage == navigationPage1)
                {
                    //редактирование сотрудника
                    DataRow curentRow = (DataRow)((DataRowView)vWEmployesBindingSource.Current).Row;
                    int currentIndex = (int)curentRow["ID"];
                    using (var employe = new Employee(currentIndex))
                    {
                        if (employe.ShowDialog() == DialogResult.OK)
                        {
                            Fill();
                        }
                    }
                }
                if (navigationPane.SelectedPage == navigationPage2)
                {
                    //редактирование Инвентаря
                    DataRow curentRow = (DataRow)((DataRowView)vWInventoryBindingSource.Current).Row;
                    int currentIndex = (int)curentRow["ID"];
                    using (var inventory = new Inventory(currentIndex))
                    {
                        if (inventory.ShowDialog() == DialogResult.OK)
                        {
                            Fill();
                        }
                    }
                }
                if (navigationPane.SelectedPage == navigationPage3)
                {
                    //редактирование софта
                    DataRow curentRow = (DataRow)((DataRowView)vWSoftBindingSource.Current).Row;
                    int currentIndex = (int)curentRow["ID"];
                    using (var soft = new Soft(currentIndex))
                    {
                        if (soft.ShowDialog() == DialogResult.OK)
                        {
                            Fill();
                        }
                    }
                }
                if (navigationPane.SelectedPage == navigationPage4)
                {
                    //редактирование Помещения
                    DataRow curentRow = (DataRow)((DataRowView)vWRoomsBindingSource.Current).Row;
                    int currentIndex = (int)curentRow["ID"];
                    using (var room = new Room(currentIndex))
                    {
                        if (room.ShowDialog() == DialogResult.OK)
                        {
                            Fill();
                        }
                    }
                }
                if (navigationPane.SelectedPage == navigationPage5)
                {
                    if (tabPane2.SelectedPage == tabNavigationPage8)
                    {
                        DataRow curentRow = (DataRow)((DataRowView)addressesBindingSource.Current).Row;
                        int currentIndex = (int)curentRow["ID"];
                        //редактирование списка адресов(новый адрес)
                        using (var adressees = new TypesForms.AdressesAdd(currentIndex))
                        {
                            if (adressees.ShowDialog() == DialogResult.OK)
                            {
                                Fill();
                            }
                        }
                    }
                    if (tabPane2.SelectedPage == tabNavigationPage6)
                    {
                        DataRow curentRow = (DataRow)((DataRowView)typesInventoryBindingSource.Current).Row;
                        int currentIndex = (int)curentRow["ID"];
                        //редактирование списка типов ивентаря(новый тип)
                        using (var inventory = new InventoryAdd(currentIndex))
                        {
                            if (inventory.ShowDialog() == DialogResult.OK)
                            {
                                Fill();
                            }
                        }
                    }
                    if (tabPane2.SelectedPage == tabNavigationPage7)
                    {
                        DataRow curentRow = (DataRow)((DataRowView)typesRoomsBindingSource.Current).Row;
                        int currentIndex = (int)curentRow["ID"];
                        //редактирование списка типов помещений(новый тип)
                        using (var roms = new TypesForms.RoomsType(currentIndex))
                        {
                            if (roms.ShowDialog() == DialogResult.OK)
                            {
                                Fill();
                            }
                        }
                    }

                }
            }
            catch
            {
                MessageBox.Show("Возникло сиситемное исключение, возможно у вас не достаточно прав для этого действия");
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var about = new TabSearchFrom())
            {
                if (about.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var about = new AboutProgramm())
            {
                if (about.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //удаление  сотрудника
                if (navigationPane.SelectedPage == navigationPage1)
                {
                    DataRow curentRow = (DataRow)((DataRowView)vWEmployesBindingSource.Current).Row;
                    BindingSource allemployes = employesBindingSource;
                    allemployes.Position = allemployes.Find("ID", curentRow["ID"]);
                    DataRow emmployecurrent = (DataRow)((DataRowView)allemployes.Current).Row;
                    emmployecurrent["Status_ID"] = 2;//статус удаленного сотрудника
                    employesBindingSource.EndEdit();
                    employesTableAdapter.Update(mainDataSet.Employes);
                    Fill();
                }
                //удаление  оборудования
                if (navigationPane.SelectedPage == navigationPage2)
                {
                    DataRow curentRow = (DataRow)((DataRowView)vWInventoryBindingSource.Current).Row;
                    BindingSource allinventory = inventoryBindingSource;
                    allinventory.Position = allinventory.Find("ID", curentRow["ID"]);
                    DataRow inventorycurrent = (DataRow)((DataRowView)allinventory.Current).Row;
                    inventorycurrent["Status_ID"] = 4;//статус удаленного сотрудника
                    inventoryBindingSource.EndEdit();
                    inventoryTableAdapter.Update(mainDataSet.Inventory);
                    Fill();
                }
                //удаление  софта
                if (navigationPane.SelectedPage == navigationPage3)
                {
                    DataRow curentRow = (DataRow)((DataRowView)vWSoftBindingSource.Current).Row;
                    BindingSource allsoft = softsBindingSource;
                    allsoft.Position = allsoft.Find("ID", curentRow["ID"]);
                    DataRow softscurrent = (DataRow)((DataRowView)allsoft.Current).Row;
                    softscurrent["Status_ID"] = 8;//статус удаленного софта
                    softsBindingSource.EndEdit();
                    softsTableAdapter.Update(mainDataSet.Softs);
                    Fill();
                }
                if (navigationPane.SelectedPage == navigationPage4)
                {
                    DataRow curentRow = (DataRow)((DataRowView)vWRoomsBindingSource.Current).Row;
                    BindingSource allroms = roomsBindingSource;
                    allroms.Position = allroms.Find("ID", curentRow["ID"]);
                    DataRow roomcurrent = (DataRow)((DataRowView)allroms.Current).Row;
                    roomcurrent["Status_ID"] = 6;//статус удаленного помещения

                    roomsBindingSource.EndEdit();
                    roomsTableAdapter.Update(mainDataSet.Rooms);
                    Fill();
                }
            }
            catch
            {
                MessageBox.Show("Возникло сиситемное исключение, возможно у вас не достаточно прав для этого действия");
            }
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel test = defaultLookAndFeeDesign;
            using (var settings = new Settings(test))
            {
                if (settings.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("It will create, soon");
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (navigationPane.SelectedPage == navigationPage1)
            {
                //просомотр сотрудника
                DataRow curentRow = (DataRow)((DataRowView)vWEmployesBindingSource.Current).Row;
                int currentIndex = (int)curentRow["ID"];
                using (var employe = new Employee(currentIndex,0))
                {
                    if (employe.ShowDialog() == DialogResult.OK)
                    {
                        Fill();
                    }
                }
            }
            if (navigationPane.SelectedPage == navigationPage2)
            {
                //редактирование Инвентаря
                DataRow curentRow = (DataRow)((DataRowView)vWInventoryBindingSource.Current).Row;
                int currentIndex = (int)curentRow["ID"];
                using (var inventory = new Inventory(currentIndex,0))
                {
                    if (inventory.ShowDialog() == DialogResult.OK)
                    {
                        Fill();
                    }
                }
            }
            if (navigationPane.SelectedPage == navigationPage3)
            {
                //редактирование софта
                DataRow curentRow = (DataRow)((DataRowView)vWSoftBindingSource.Current).Row;
                int currentIndex = (int)curentRow["ID"];
                using (var soft = new Soft(currentIndex,0))
                {
                    if (soft.ShowDialog() == DialogResult.OK)
                    {
                        Fill();
                    }
                }
            }
            if (navigationPane.SelectedPage == navigationPage4)
            {
                //редактирование Помещения
                DataRow curentRow = (DataRow)((DataRowView)vWRoomsBindingSource.Current).Row;
                int currentIndex = (int)curentRow["ID"];
                using (var room = new Room(currentIndex,0))
                {
                    if (room.ShowDialog() == DialogResult.OK)
                    {
                        Fill();
                    }
                }
            }
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var backUp = new BackUpModule())
            {
                if (backUp.ShowDialog() == DialogResult.OK)
                {
                    Fill();
                }
            }
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var logData = new LogData())
            {
                if (logData.ShowDialog() == DialogResult.OK)
                {
                    Fill();
                }
            }
        }
    }
}
