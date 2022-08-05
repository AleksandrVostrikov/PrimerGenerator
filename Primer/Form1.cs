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
        private void button1_Click(object sender, EventArgs e)
        {
            FillTextboxesSubtraction();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FillTextboxesAddition();
        }
        private int[][] GetDescription()
        {
            int[][] result = new int[2][];
            int[] descRange = new int[2];
            int[] descAnswer = new int[2];
            descRange[0] = Convert.ToInt32(rangeFrom.Value);
            descRange[1] = Convert.ToInt32(rangeTo.Value);
            descAnswer[0] = Convert.ToInt32(answerFrom.Value);
            descAnswer[1] = Convert.ToInt32(answerTo.Value);
            result[0] = descRange;
            result[1] = descAnswer;
            return result;
        }
        private void FillTextboxesAddition()
        {
            int[] range = GetDescription()[0];
            int[] answer = GetDescription()[1];
            int problemQuantity = Convert.ToInt32(quantity.Value);
            string mathProblem = "";
            string mathProblemWithAnswers = "";
            SimpleCalculator rand = new SimpleCalculator();
            for (int i = 0; i < problemQuantity; i++)
            {
                string[] middle = rand.GetAddition(range, answer);
                mathProblem += middle[1];
                mathProblemWithAnswers += middle[0];
            }
            tbProblems.Text = mathProblem;
            tbAnswers.Text = mathProblemWithAnswers;
        }
        private void FillTextboxesSubtraction()
        {
            int[] range = GetDescription()[0];
            int[] answer = GetDescription()[1];
            int problemQuantity = Convert.ToInt32(quantity.Value);
            string mathProblem = "";
            string mathProblemWithAnswers = "";
            SimpleCalculator rand = new SimpleCalculator();
            for (int i = 0; i < problemQuantity; i++)
            {
                string[] middle = rand.GetSubtraction(range, answer);
                mathProblem += middle[1];
                mathProblemWithAnswers += middle[0];
            }
            tbProblems.Text = mathProblem;
            tbAnswers.Text = mathProblemWithAnswers;
        }

        private void answerTo_ValueChanged(object sender, EventArgs e)
        {
            if ((answerTo.Value < answerFrom.Value) & answerTo.Value != 0) answerFrom.Value = answerTo.Value - 1;
            if (answerTo.Value == 0) answerFrom.Value = 0;
        }

        private void answerFrom_ValueChanged(object sender, EventArgs e)
        {
            if ((answerFrom.Value >= answerTo.Value) & answerTo.Value != 0) answerFrom.Value = answerTo.Value - 1;
            if (answerTo.Value == 0) answerFrom.Value = 0;
        }
    }
}
