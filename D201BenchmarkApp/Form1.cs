// Student Name： Yuxi Wang    
// Student ID: 22001587

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace D201BenchmarkApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        List<MyClass> creatures = new List<MyClass>();
        MyClass selectModel=null;
        //Default edit
        int modelNum = 0;
    
        /// <summary>
        /// Windows form.
        /// </summary>
        public Form()
        {
            InitializeComponent();
            creatures = new List<MyClass>(); ;
            this.dataGridView1.DataError += delegate(object sender, System.Windows.Forms.DataGridViewDataErrorEventArgs e)
            {
            };

        }
        
        /// <summary>
        /// Button Load click action method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            creatures.Clear();
            FileManager fm = new FileManager();
            creatures = fm.LoadCreatures();
            // Judge if creatures is null.
            if (creatures == null)
            {
                MessageBox.Show("Error Loading Creatures", "File IO Error");
            }
            else
            {                
                Control.CheckForIllegalCrossThreadCalls = false;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = creatures;
            }
            clear();
            tbxIdInput.Enabled = true;
        }

        /// <summary>
        /// Button SortAZ click action method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortAZ_Click(object sender, EventArgs e)
        {
            Filter cFilter = new Filter();

            creatures = cFilter.SortAZ(creatures);

            Control.CheckForIllegalCrossThreadCalls = false;
            dataGridView1.DataSource = creatures;
         
        }

        /// <summary>
        /// Button SortZA click action method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortZA_Click(object sender, EventArgs e)
        {
            Filter cFilter = new Filter();

            creatures = cFilter.SortZA(creatures);

            Control.CheckForIllegalCrossThreadCalls = false;
            dataGridView1.DataSource = creatures;
        }


        /// <summary>
        /// Button Search click action method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<MyClass> results = new List<MyClass>();
            Filter cFilter = new Filter();
            string term = tbxSearch.Text;
            results = cFilter.Search(creatures, term);

            lbxSearchResults.Items.Clear();
            lbxSearchResults.Items.AddRange(results.ToArray());
        }


        /// <summary>
        /// Button Save click action method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                FileManager fm = new FileManager();
                MyClass c = (MyClass)lbxSearchResults.SelectedItem;
                // Set fileName format.
                string fileName = c.Id + " " + c.Staff_Name + ".txt";
                bool result = fm.SaveCreature(c, fileName);
                if (result == false)
                {
                    MessageBox.Show("Error Saving Staff Details", "File IO Error");
                }
                else
                {
                    // Confirm if to view file.
                    DialogResult dr = MessageBox.Show("View File?", "Save successfully", MessageBoxButtons.YesNo);

                    if (dr.Equals(DialogResult.Yes))
                    {
                        System.Diagnostics.Process.Start(fileName);
                    }
                }
            }
            catch (Exception)
            {
                // If user doesn't choose a staff, gives Error remind.
                MessageBox.Show("Please select a staff", "Error");
            }
        }

        /// <summary>
        /// Select search result click action method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MyClass c = (MyClass)lbxSearchResults.SelectedItem;

                tbxId.Text = c.Id.ToString();
                tbxName.Text = c.Staff_Name;
                tbxBirthday.Text = c.Birthday;
                tbxEmail.Text = c.Email;
                tbxSalary.Text = "$"+ c.Salary.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }

        }

        /// <summary>
        /// Show staff information method.
        /// </summary>
        public void show()
        {
            if (selectModel==null)
            {
                return;
            }
            tbxIdInput.Text = selectModel.Id.ToString();
            tbxNameInput.Text = selectModel.Staff_Name.ToString();
            dateTimePicker1.Value = DateTime.Parse(selectModel.Birthday);
            tbxEmailInput.Text = selectModel.Email;
            tbxSalaryInput.Text = selectModel.Salary.ToString();
        }
        
        /// <summary>
        /// Clear method, clear all inputing areas.
        /// </summary>
        public void clear()
        {
            tbxIdInput.Text ="";
            tbxNameInput.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            tbxEmailInput.Text = "";
            tbxSalaryInput.Text = "";
        }

        /// <summary>
        /// DataGridView click action method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectModel = null;
            modelNum = 1;
            try
            {
                tbxIdInput.Enabled = false;
                var dataRow = this.dataGridView1.SelectedRows[0];
                var dataId = Convert.ToInt32(dataRow.Cells[0].Value);
                //Obtain Id
                var model = creatures.Where(a => a.Id == dataId).FirstOrDefault();
                selectModel = model;
                show();
            }
            catch (Exception)
            {
               
            }
          
   
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Button delete click action method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectModel != null)
                {       
                        // Double confirm to delete the staff.
                        DialogResult dr = MessageBox.Show("Are you sure to delete the staff?","", MessageBoxButtons.YesNo);
                        if (dr.Equals(DialogResult.Yes))
                        {
                            var res = creatures.Remove(selectModel);
                            Control.CheckForIllegalCrossThreadCalls = false;
                            dataGridView1.DataSource = creatures;
                            MessageBox.Show("Staff was deleted successfully!");
                            FileManager.SaveFiles(creatures);
                            clear();
                            tbxIdInput.Enabled = true;
                            
                       }
                        else
                       {
                            // Cancel delete operation.
                            MessageBox.Show("You have cancelled deleting.");
                            clear();
                            tbxIdInput.Enabled = true;
                            return;
                        }                                                              
                    }               
                else
                {
                    // If don't choose a staff, then remind user to choose one.
                    MessageBox.Show("Please choose a staff!");
                    clear();
                    return;
                }
                
                tbxIdInput.Enabled = true;
                modelNum = 0;
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error! Please check!");
            }
        }


        /// <summary>
        /// Button Add(Save) click action method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveInput_Click(object sender, EventArgs e)
        {
            try
            {
                var ids = tbxIdInput.Text;
                var name = tbxNameInput.Text;
                var birth = dateTimePicker1.Value;
                var email = tbxEmailInput.Text;
                var salary = tbxSalaryInput.Text;

                // If user leaves blank in input box.
                if (ids.Length == 0 || name.Length == 0 || email.Length == 0 || salary.Length == 0)
                {
                    MessageBox.Show("Input information cannot be blank!", "Error");
                    return;
                }

                //Set time range between 1900 and 2020.
                int yr = this.dateTimePicker1.Value.Year;
                if(yr > 2020 || yr < 1900)
                {
                    MessageBox.Show("Date must be between 1900-2020!", "Error");
                    return;
                }
               
                //Set name format must be English letters. Space is allowed.
                string na = name.ToString();
                bool legalName = Regex.Matches(na, "^[a-zA-Z\\s]+$").Count > 0;
                if(!legalName )
                {
                    MessageBox.Show("Name must be English letters!", "Error");
                    return;
                }
                
                // Set email format must contain "." and "@".
                if (!(email.Contains("@") && email.Contains(".")))
                {
                    MessageBox.Show("Wrong email format!","Error");
                    return;
                }

                // Set salary must be positive numbers, max digital length 10.
                int res = 0;
                var s = int.TryParse(salary, out res);
                if (!s)
                {
                    MessageBox.Show("Salary must be numbers!","Error");
                    return;
                }

                if (salary.Contains("-"))
                {
                    MessageBox.Show("Salary cannot be negative numbers!","Error");
                    return;
                }

                // Set ID must be positive numbers, max digital length 10.
                int id = -1;
                s = int.TryParse(ids, out id);
                if (!s)
                {
                    MessageBox.Show("ID must be numbers (Maximum: 10 digits)!","Error");
                    return;
                }

                if (ids.Contains("-"))
                {
                    MessageBox.Show("ID cannot be negative numbers!","Error");
                    return;
                }


                MyClass myClass = new MyClass();
                myClass.Id = Convert.ToInt32(ids);
                myClass.Staff_Name = name;
                //13/08/2016
                myClass.Birthday = birth.Day.ToString() + "/" + birth.Month.ToString() + "/" + birth.Year.ToString();
                myClass.Email = email;
                myClass.Salary = res;
                // Save or Edit
                if (modelNum == 0)
                {
                    // Save(Add)
                    creatures.Add(myClass);
                    Control.CheckForIllegalCrossThreadCalls = false;
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = creatures;
                    MessageBox.Show("Staff was added successfully!");
                    FileManager.SaveFiles(creatures);
                    
                }
                else
                {   
                    //Edit(Add)
                    var dad = creatures.Where(a => a.Id == id).FirstOrDefault();
                    if (dad != null)
                    {
                        creatures.Remove(dad);
                        creatures.Add(myClass);
                        Control.CheckForIllegalCrossThreadCalls = false;
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = creatures;
                        MessageBox.Show("Staff was edited successfully!");
                        FileManager.SaveFiles(creatures);
                        
                    }
                }

                clear();
                tbxIdInput.Enabled = true;
                modelNum = 0;
            }catch(Exception )
            {
                MessageBox.Show("Please try again!", "Error");
            }
           
        }
           


        /// <summary>
        /// Button Clear click action method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            tbxIdInput.Enabled = true;
            modelNum = 0;
        }
    }
}