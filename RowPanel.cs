using System.Windows.Forms;

namespace Mastermind
{
    public class RowPanel : Panel
    {
        public Label indicator1;
        public Label indicator2;
        public Label indicator3;
        public Label indicator4;
        public Panel red1;
        public Panel red2;
        public Panel red3;
        public Panel red4;
    
        public RowPanel()
        {
            red1 = new Panel();
            red2 = new Panel();
            red3 = new Panel();
            red4 = new Panel();
            indicator1 = new Label();
            indicator2 = new Label();
            indicator3 = new Label();
            indicator4 = new Label();
            SuspendLayout();
            
            // 
            // red3
            // 
            red3.BackColor = System.Drawing.Color.Red;
            red3.Location = new System.Drawing.Point(153, 24);
            red3.Name = "red3";
            red3.Size = new System.Drawing.Size(15, 15);
            red3.TabIndex = 16;
            // 
            // red2
            // 
            red2.BackColor = System.Drawing.Color.Red;
            red2.Location = new System.Drawing.Point(174, 3);
            red2.Name = "red2";
            red2.Size = new System.Drawing.Size(15, 15);
            red2.TabIndex = 14;
            // 
            // red4
            // 
            red4.BackColor = System.Drawing.Color.Red;
            red4.Location = new System.Drawing.Point(174, 24);
            red4.Name = "red4";
            red4.Size = new System.Drawing.Size(15, 15);
            red4.TabIndex = 15;
            // 
            // red1
            // 
            red1.BackColor = System.Drawing.Color.Red;
            red1.Location = new System.Drawing.Point(153, 3);
            red1.Name = "red1";
            red1.Size = new System.Drawing.Size(15, 15);
            red1.TabIndex = 13;
            // 
            // indicator4
            // 
            indicator4.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            indicator4.Location = new System.Drawing.Point(107, 3);
            indicator4.Name = "indicator4";
            indicator4.Size = new System.Drawing.Size(25, 30);
            indicator4.TabIndex = 12;
            // 
            // indicator3
            // 
            indicator3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            indicator3.Location = new System.Drawing.Point(76, 3);
            indicator3.Name = "indicator3";
            indicator3.Size = new System.Drawing.Size(25, 30);
            indicator3.TabIndex = 11;
            // 
            // indicator2
            // 
            indicator2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            indicator2.Location = new System.Drawing.Point(45, 3);
            indicator2.Name = "indicator2";
            indicator2.Size = new System.Drawing.Size(25, 30);
            indicator2.TabIndex = 10;
            // 
            // indicator1
            // 
            indicator1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            indicator1.Location = new System.Drawing.Point(14, 3);
            indicator1.Name = "indicator1";
            indicator1.Size = new System.Drawing.Size(25, 30);
            indicator1.TabIndex = 9;
            
            Controls.Add(red3);
            Controls.Add(red2);
            Controls.Add(red4);
            Controls.Add(red1);
            Controls.Add(indicator4);
            Controls.Add(indicator3);
            Controls.Add(indicator2);
            Controls.Add(indicator1);
            Location = new System.Drawing.Point(30, 480);
            Name = "row1";
            Size = new System.Drawing.Size(197, 44);
            TabIndex = 13;
            //ResumeLayout(false);
        }
    }
}