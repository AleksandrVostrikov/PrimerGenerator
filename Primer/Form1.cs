using System;
using System.Windows.Forms;

namespace Primer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FillTextboxesAddition();
        }
        private void FillTextboxesAddition()
        {
            int[] a = { 10, 50 };
            int[] c = { 10, 0 };
            int quantity = 10;
            string mathProblem = "";
            string mathProblemWithAnswers = "";
            SimpleCalculator rand = new SimpleCalculator();
            for (int i = 0; i < quantity; i++)
            {
                string[] middle = rand.GetAddition(a, c);
                mathProblem += middle[1];
                mathProblemWithAnswers += middle[0];
            }
            tbProblems.Text = mathProblem;
            tbAnswers.Text = mathProblemWithAnswers;
        }
        private void FillTextboxesSubtraction()
        {
            int[] a = { 10, 100 };
            int[] c = { 10,  0};
            int quantity = 10;
            string mathProblem = "";
            string mathProblemWithAnswers = "";
            SimpleCalculator rand = new SimpleCalculator();
            for (int i = 0; i < quantity; i++)
            {
                string[] middle = rand.GetSubtraction(a, c);
                mathProblem += middle[1];
                mathProblemWithAnswers += middle[0];
            }
            tbProblems.Text = mathProblem;
            tbAnswers.Text = mathProblemWithAnswers;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillTextboxesSubtraction();
        }
    }
}
