using Member3.Member1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Member3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Member c = new Member();

        string mon, tue, wed, thu, fri, sat, sun, days;
        int hours,min;
        

        private void Addbutton1_Click(object sender, EventArgs e)
        {
            //get the values from input feilds
            c.numofworkingdays = Convert.ToInt32(numofworkingdays.Value);

             if (MondaycheckBox.Checked == true)
               {
                  mon = "Monday";
                  days = mon;
                  c.days = days;
              }
              else if(MondaycheckBox.Checked==true && TuesdaycheckBox.Checked == true)
              {
                 mon = "Monday";
                 tue = "Tuesday";

                 days = mon + tue;
                 c.days = days;
              }
             else if (MondaycheckBox.Checked == true && TuesdaycheckBox.Checked == true && WednesdaycheckBox.Checked == true)
            {
                mon = "Monday";
                tue = "Tuseday";
                wed = "Wednesday";

                days = mon + tue + wed;
                c.days = days;
            }
             else if (MondaycheckBox.Checked == true && TuesdaycheckBox.Checked == true && WednesdaycheckBox.Checked == true && ThursdaycheckBox.Checked == true)
            {
                mon = "Monday";
                tue = "Tuseday";
                wed = "Wednesday";
                thu = "Thursday";

                days = mon + tue + wed + thu;
                c.days = days;

            }
             else if (MondaycheckBox.Checked == true && TuesdaycheckBox.Checked == true && WednesdaycheckBox.Checked == true && ThursdaycheckBox.Checked == true && FridaycheckBox.Checked == true)
            {
                mon = "Monday";
                tue = "Tuseday";
                wed = "Wednesday";
                thu = "Thursday";
                fri = "Friday";

                days = mon + tue + wed + thu + fri;
                c.days = days;
            }
             else if (MondaycheckBox.Checked == true && TuesdaycheckBox.Checked == true && WednesdaycheckBox.Checked == true && ThursdaycheckBox.Checked == true && FridaycheckBox.Checked == true && SaturdaycheckBox.Checked == true)
            {
                mon = "Monday";
                tue = "Tuseday";
                wed = "Wednesday";
                thu = "Thursday";
                fri = "Friday";
                sat = "Saturday";

                days = mon + tue + wed + thu + fri + sat;
                c.days = days;
            }
             else if (MondaycheckBox.Checked == true && TuesdaycheckBox.Checked == true && WednesdaycheckBox.Checked == true && ThursdaycheckBox.Checked == true && FridaycheckBox.Checked == true && SaturdaycheckBox.Checked == true && SundaycheckBox.Checked == true)
            {
                mon = "Monday";
                tue = "Tuseday";
                wed = "Wednesday";
                thu = "Thursday";
                fri = "Friday";
                sat = "Saturday";
                sun = "Sunday";
                    
                days = mon + tue + wed + thu + fri + sat + sun;
                c.days = days;
            }
             




            hours = Convert.ToInt32(Hoursnumeric.Value);
            min = Convert.ToInt32(Minutenumeric.Value);
            String numHours = hours + ":" + min;

            bool success = c.Insert(c);
            if (success == true)
            {
                MessageBox.Show("Data insert successfuly");
            }
            else
            {
                MessageBox.Show("Try Again");
            }

            //load data in the datagridview
            DataTable dt = c.Select();
            dataGridView1.DataSource = dt;



        }
    }
}
