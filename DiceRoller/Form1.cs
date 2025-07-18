namespace DiceRoller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            List<int> rolls = new();
            Die d = new Die(20);
            rolls.Add(d.Roll());
            rolls.Add(d.Roll());
            rolls.Add(d.Roll());
            rolls.Add(d.Roll());
            rolls.Add(d.Roll()); 
            rolls.Add(d.Roll());    
            rolls.Add(d.Roll());

            MessageBox.Show(string.Join(", ", rolls));
            InitializeComponent();
        }
    }
}
