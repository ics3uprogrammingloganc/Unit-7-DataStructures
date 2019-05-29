/*
 * Created by: Logan Cantin 
 * Created on: May 28, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #42 - Canada Post Struct
 * This program collects user information and holds it in a struct
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostalCodeLoganC
{
    public partial class frmPostal : Form
    {
        public frmPostal()
        {
            InitializeComponent();
        }


        public struct PostalAddress
        {
            public string name, postalcode, address, city, province, country;

            public PostalAddress(string n, string p, string a, string c, string pr, string coun)
            {
                name = n;
                postalcode = p;
                address = a;
                city = c;
                province = pr;
                country = coun;
            }
        }
    
        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            // setting variables
            string name = txtName.Text;
            string postalcode = txtPostal.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string province = txtProvince.Text;
            string country = txtCountry.Text;

            // Creating object
            PostalAddress dest = new PostalAddress(name, postalcode, address, city, province, country);

            // Show the information in a formatted way
            MessageBox.Show(string.Format("{0} who lives at {1}, {2}. They live in {3}, {4}, {5}.", dest.name, dest.postalcode, dest.address,
                dest.city, dest.province, dest.country));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
