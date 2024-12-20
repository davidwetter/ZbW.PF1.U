﻿namespace MB04.ArrayUebung
{
    public partial class ArrayUebungMehrdimensional : Form
    {
        public ArrayUebungMehrdimensional()
        {
            InitializeComponent();
        }

        private void CmdShow_Click(object sender, EventArgs e)
        {
            string[,] weekActivities = new string[2, 7]{
        { "Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sonntag" },
        { "Sport", "Lesen", "Einkaufen", "Kochen", "Wandern", "Spazieren", "Entspannen" }  };

            LblShow.Text = "Wochenaktivitäten:\n";

            for (int y = 0; y < weekActivities.GetUpperBound(0); y++)
            {
                for (int x = 0; x < weekActivities.GetUpperBound(1); x++)
                {
                    LblShow.Text += $"{weekActivities[y, x]}: {weekActivities[y, x]}\r\n";
                }
            }
        }
    }


}
