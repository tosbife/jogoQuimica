using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace JogoQuimica
{
    public partial class Form1 : Form
    {
        Random random;
        public static string[][] Equations;
        public static Dictionary<string, float> equation1, equation2;
        public static int pontos = -1, i;
        public static Form2 f = new Form2();
        
        public Form1()
        {
            InitializeComponent();
            
            ResetGame();
        }

        private void ResetGame()
        {
            pontos = 0;

            random = new Random();
            equation1 = new Dictionary<string, float>();
            equation2 = new Dictionary<string, float>();

            size = 160;
            min = 2;
            seg = 40;

            Equations = @"H2 + O = (OH)2
Al2O3 + HCl = AlCl3 + H2O
SO2 + NaOH = Na2SO3 + H2O
BaO4 + HNO3 = Ba(NO3)2 + H2O2 + O2
Mg + HCl = MgCl2 + H2
C8H18 + O2 = CO2 + H2O
C4H10O + O2 = CO2 + H2O
Al + Cl2 = AlCl3
N2H4 + N2O4 = N2 + H2O
CaO + H3PO4 = Ca3(PO4)2 + H2O
K + Cl2 = 2KCl
SO2 + H2O = H2SO4
CH4 + 2O2 = CO2 + H2O
PbSO4 + 2Na2S = PbS + Na2SO4
CH4 + O2 = CO2 + 2H2O
CaCO = Ca + C + O3
Ca(OH)2 + H3PO4 = Ca3(PO4)2 + H2O
CaCO3 = CaO + CO2 + O
H2 + Cl2 = HCl
SO3 + H2O = 2H2SO4
P2O5 + H2O = H3PO4
Zn + HBr = ZnBr2 + H2
Al + HCl = AlCl3 + H2
Cu + AgNO3 = Ag + Cu(NO3)2
Cl2 + CH4 = CH2Cl2 + HCl
C2H6O + O2 = CO2 + H2O
AgNO3 + BaCl2 = AgCl + Ba(NO3)2
H3PO4 + Ca(NO3)2 = Ca3(PO4)2 + HNO3
C2H6O + O2 = CO2 + H2O
Na2CO3 + HCl = NaCl + H2O + CO2
C6H12O6 = C2H6O + CO2
C4H10 + O2 = CO2 + H2O
FeCl3 + Na2CO3 = Fe2(CO3)3 + NaCl
NH4Cl + Ba(OH)2 = BaCl2 + NH3 + H2O
Ca(OH)2 + H3PO4 = Ca3(PO4)2 + H2O
Fe2(CO3)3 + H2SO4 = Fe2(SO4)3 + H2O + CO2
Na2O + (NH4)2SO4 = Na2SO4 + H2O + NH3
FeS2 + O2 = Fe2O3 + SO2
NH3 + O2 = NO + H2O
KMnO4 + H2SO4 = Mn2O7 + K2SO4 + H2O
CS2 + O2 = CO2 + SO2
H3PO4 + CaO = Ca3(PO4)2 + H2O
Na2CO3 + H3PO4 = Na3PO4 + H2O + CO2
KMnO4 = K2MnO4 + MnO2 + O2
Na + KNO3 = Na2O + K2O + N2
Ni(CO)4 = Ni + CO
(CaC2)2 + H2O = C2H2 + CaO"
.Split('\n')
.Select(line => line.Split('='))
.ToArray();
        }

        private void BPlay_Click(object sender, EventArgs e)
        {
            setRandomEquation();
            correctFormat();

            bConfirm.Enabled = true;
            timer1.Enabled = true;
            tEq1.Enabled = true;
            tEq2.Enabled = true;
            bReset.Enabled = true;
            bPlay.Enabled = false;
            timerBar.BackColor = Color.LimeGreen;
        }


        private void setRandomEquation()
        {
            var eq = Equations[i = random.Next(0, 47)];
            tEq1.Text = eq[0];
            tEq2.Text = eq[1];
            gbGame.Text = "Pontos: " + ++pontos;
        }

        private void CreateWindow()
        {
            f.Close();
            f = new Form2();
            f.Size = new Size(f.Size.Width, 80 + 40 * Math.Max(equation1.Count, equation2.Count));
            float max = -1;

            // Gets the maximum n° of occurrences
            var x = equation1.ToList();
            x.AddRange(equation2.ToList());
            foreach (var elem in x)
                max = Math.Max(elem.Value, max);

            int len = equation1.Count;
            KeyValuePair<string, float>[] elems = new KeyValuePair<string, float>[2];
            var e1 = equation1.OrderBy(elem => elem.Key);
            var e2 = equation2.OrderBy(elem => elem.Key);
            for (int i = 0; i < len; i++)
            {
                elems[0] = e1.ElementAt(i);
                elems[1] = e2.ElementAt(i);
                for (int j = 0; j < 2; j++)
                {
                    var ctrl = new UserControl1(elems[j].Key, elems[j].Value, 40 + i * 40, j == 0);
                    ctrl.ResizeW(elems[j].Value / max);
                    f.Controls.Add(ctrl);
                }
            }
            f.Show();
        }

        private bool correctFormat()
        {
            try
            {
                equation1 = getFinalEquation(tEq1.Text);
                equation2 = getFinalEquation(tEq2.Text);

                CreateWindow();
            }
            catch (Exception)
            {                
                return false;
            }
            return true;
        }

        private void TEq1_TextChanged(object sender, EventArgs e)
        {
            correctFormat();
        }

        private void TEq2_TextChanged(object sender, EventArgs e)
        {
            correctFormat();
        }

        private Dictionary<string, float> getFinalEquation(string text)
        {
            Dictionary<string, float> eq = new Dictionary<string, float>();
            eq.Clear();
            foreach (var mol in text.Split('+'))
                foreach (var elem in getElementsFrom(mol))
                    if (eq.ContainsKey(elem.Key))
                        eq[elem.Key] += elem.Value;
                    else
                        eq.Add(elem.Key, elem.Value);

           return eq;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!correctFormat())
            {
                MessageBox.Show("Formato inválido!");
                return;
            }
            if (equation1.All(elem => equation2.Contains(elem)))
            {
                MessageBox.Show("Correto!", "Mensagem");
                size += 30;
                seg += 30;
                if (seg > 60)
                {
                    min += 1;
                    seg -= 60;
                }

                setRandomEquation();
                correctFormat();
            }
            else
                MessageBox.Show("Errado!", "Mensagem");
        }

        int size, min, seg;

        private void BReset_Click(object sender, EventArgs e)
        {
            tEq1.Text = Equations[i][0];
            tEq2.Text = Equations[i][1];
            correctFormat();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timerBar.Size = new Size(size--, 17);

            if (--seg < 0)
            {
                seg = 59;
                min--;
                if (min < 0)
                {                    
                    DialogResult r = MessageBox.Show("Parabéns! Você fez " + pontos + " pontos!\nVocê deseja tentar novamente?", "Mensagem", MessageBoxButtons.YesNo);
                    if (r == DialogResult.Yes)
                    {
                        timer1.Enabled = false;
                        bConfirm.Enabled = false;
                        bReset.Enabled = false;
                        bPlay.Enabled = true;
                        tEq1.Enabled = false;
                        tEq2.Enabled = false;
                        timerBar.BackColor = Color.LightGreen;

                        min = 2;
                        seg = 40;

                        ResetGame();
                    }
                    else
                        Close();
                }
            }
            lTimer.Text = "Timer: (" + min.ToString("00") + ":" + seg.ToString("00") + ")";
        }

        private Dictionary<string, float> getElementsFrom(string equation)
        {
            equation = new string(equation.ToCharArray()
                .Where(ch => !Char.IsWhiteSpace(ch))
                .ToArray());

            Dictionary<string, float> elements = new Dictionary<string, float>();

            Stack<float> multipliers = new Stack<float>();
            multipliers.Push(1);

            char c;
            bool instant = false;
            for (int i = equation.Length-1; i >= 0; i--)
            {
                c = equation[i];

                // Number
                if (Char.IsNumber(c))
                {
                    int endNum = i;
                    float num = getWholeNumberFrom(equation, ref i);

                    // Right-sided numbers
                    if (i > 0 && (endNum + 1 == equation.Length || Char.IsLetter(equation[i - 1])))
                    {
                        if (equation[i - 1] != ')')
                            instant = true;                        
                        multipliers.Push(num * multipliers.Peek());
                    }
                    // Left-sided numbers
                    else
                        elements = elements.ToDictionary(
                            elem => elem.Key,
                            elem => elem.Value * num);
                }
                // Element
                else if (Char.IsLetter(c))
                {
                    int isTwoDigit = (Char.IsLower(c)) ? 1 : 0;
                    string name = equation.Substring(i - isTwoDigit, 1 + isTwoDigit);

                    if (elements.ContainsKey(name))
                        elements[name] += multipliers.Peek();
                    else
                        elements.Add(name, multipliers.Peek());

                    if (instant) {
                        multipliers.Pop();
                        instant = false;
                    }

                    i -= isTwoDigit;
                }
                // Close parenthesis
                else if (c == '(')
                    multipliers.Pop();
            }

            return elements;
        }        

        static float getWholeNumberFrom(string equation, ref int i)
        {
            char c;
            int j = i, tam;
            while (--j >= 0 && (Char.IsNumber(c = equation[j]) || c == '.'));

            j += 1;
            tam = i - j + 1;
            i = j;

            float n;
            return n = float.Parse(equation.Substring(i, tam), CultureInfo.InvariantCulture.NumberFormat);
        }
    }
}
