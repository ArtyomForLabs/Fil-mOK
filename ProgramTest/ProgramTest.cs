using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fil_mOK;

namespace ProgramTest
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void RunApplication()
        {
            try
            {
                Program.Main();
            }
            catch { Assert.Fail("Application wasn't run!"); }
        }

        [TestMethod]
        public void Run_room()
        {
            try
            {
                room r = new room();
                r.time = "11:11";
                r.ShowDialog();
            }
            catch { Assert.Fail("room wasn't loaded!"); }
        }

        [TestMethod]
        public void RunForm2()
        {
            try
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            catch { Assert.Fail("Form2 wasn't loaded!"); }
        }

        [TestMethod]
        public void RunForm3()
        {
            try
            {
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
            catch { Assert.Fail("Form3 wasn't loaded!"); }
        }
       
        [TestMethod]
        public void RunForm1()
        {
            try
            {
                Form1 f1 = new Form1();
                f1.ShowDialog();
            }
            catch (Exception e)
            {
                Assert.Fail("Form1 wasn't loaded!");
            }
        }

        [TestMethod]
        public void Button1_Click_NoData_Form3()
        {
            Form3 f3 = new Form3();
            f3.button1_Click(f3.button1,EventArgs.Empty);
        }

        [TestMethod]
        public void Button1_Click_ADMIN_Form3()
        {
            Form3 f3 = new Form3();
            f3.Owner = new Form2();
            f3.textBox1.Text = "AdminART";
            f3.maskedTextBox1.Text = "qwerty123";
            f3.button1_Click(f3.button1, EventArgs.Empty);
        }

        [TestMethod]
        public void _1111seanse_Click_Form2()
        {
            Form2 f2 = new Form2();
            f2.label1_Click(f2.label1,EventArgs.Empty);
        }

        [TestMethod]
        public void _1250seanse_Click_Form2()
        {
            Form2 f2 = new Form2();
            f2.label2_Click(f2.label2, EventArgs.Empty);
        }

        [TestMethod]
        public void enter_Click_Form2()
        {
            Form2 f2 = new Form2();
            f2.войтиToolStripMenuItem_Click(f2.войтиToolStripMenuItem, EventArgs.Empty);
        }

        [TestMethod]
        public void changer_Click_Form2()
        {
            Form2 f2 = new Form2();
            f2.редакторToolStripMenuItem_Click(f2.редакторToolStripMenuItem, EventArgs.Empty);
        }

        [TestMethod]
        public void book_noSeat_Click_room()
        {
            room r = new room();
            r.time = "12:50";
            r.button1_Click(r.button1, EventArgs.Empty);
        }

        [TestMethod]
        public void book_1Seat_Click_room()
        {
            room r = new room();
            r.time = "12:50";
            r.Show();
            r.addseat(r.bt[2],EventArgs.Empty);
            
            r.button1_Click(r.button1, EventArgs.Empty);
        }

        [TestMethod]
        public void book_2Seats_Click_room()
        {
            room r = new room();
            r.time = "12:50";
            r.Show();
            r.addseat(r.bt[4], EventArgs.Empty);
            r.addseat(r.bt[5], EventArgs.Empty);
            r.button1_Click(r.button1, EventArgs.Empty);
        }

        [TestMethod]
        public void select_2Seats_room()
        {
            room r = new room();
            r.time = "12:50"; 
            r.Show();
            r.addseat(r.bt[5], EventArgs.Empty);
            r.addseat(r.bt[6], EventArgs.Empty);
            r.Hide();
            r.ShowDialog();
        }

        [TestMethod]
        public void remove_select_2Seats_room()
        {
            room r = new room();
            r.time = "12:50";
            r.Show();
            r.addseat(r.bt[5], EventArgs.Empty);
            r.addseat(r.bt[6], EventArgs.Empty);
            r.removeseat(r.bt[5], EventArgs.Empty);
            r.removeseat(r.bt[6], EventArgs.Empty);
            r.Hide();
            r.ShowDialog();
        }
    }
}
