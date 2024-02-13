using System.ComponentModel;
using System.Windows.Forms;

namespace FlightSimulatorControlCenter
{
    public partial class Step1Init : Form
    {
        private BindingList<AereoBl> aerei;

        public Step1Init()
        {
            InitializeComponent();
        }

        private void Step1Init_Load(object sender, EventArgs e)
        {
            // Def data source
            aerei = new BindingList<AereoBl>();
            var source = new BindingSource(aerei, null);

            // Binding data source
            tabellaAerei.DataSource = source;

            // Fit colonne a size tabella
            tabellaAerei.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabellaAerei.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            // Cambio label tabella
            tabellaAerei.Columns[0].HeaderText = "Id Aereo";
            tabellaAerei.Columns[0].Name = "IdAereo";

            tabellaAerei.Columns[1].HeaderText = "Cod Aereo";
            tabellaAerei.Columns[1].Name = "Codice";

            tabellaAerei.Columns[2].HeaderText = "Colore";
            tabellaAerei.Columns[2].Name = "Colore";

            tabellaAerei.Columns[3].HeaderText = "Num. Posti";
            tabellaAerei.Columns[3].Name = "NumeroDiPosti";

            label5.Text = "Flotta Rayanair";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Recupero campi form
            var formCodice = this.textBox1.Text;
            var formColore = this.textBox2.Text;
            var formNumeroDiPosti = long.Parse(this.textBox3.Text);


            // Salvo in locale
            var a1 = AereoBl.AereoBlFactory(1, formCodice, formColore, formNumeroDiPosti);
            aerei.Add(a1);

            // Qui faro la mia chiamata in remoto
        }       

        private void button2_Click(object sender, EventArgs e)
        {
            // Chiamata di aggiornamento della lista di aerei nella tabella
            SelezionaFlotta flottaForm = new SelezionaFlotta();
            this.Hide();
            flottaForm.ShowDialog();
            this.Close();


            //flottaForm.TopLevel = false;
            //this.Controls.Add(flottaForm);
            //flottaForm.Show();
        }
    }

    // Classe di appoggio da spostare
    public class AereoBl
    {

        public long IdAereo { get; set; }
        public string Codice { get; set; }
        public string Colore { get; set; }
        public long NumeroDiPosti { get; set; }

        public AereoBl()
        {
        }

        protected AereoBl(long idAereo, string codice, string colore, long numeroDiPosti)
        {
            this.IdAereo = idAereo;
            this.Codice = codice;
            this.Colore = colore;
            this.NumeroDiPosti = numeroDiPosti;
        }

        public static AereoBl AereoBlFactory(long idAereo, string codice, string colore, long numeroDiPosti)
        {
            return new AereoBl(idAereo, codice, colore, numeroDiPosti);
        }
    }
}
