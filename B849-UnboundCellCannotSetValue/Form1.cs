namespace B849_UnboundCellCannotSetValue
{
    public partial class Form1 : Form
    {
        private DataSet1 dataSet1 = new();
        public Form1()
        {
            InitializeComponent();

            bindingSource1.DataSource = dataSet1;
            bindingSource1.DataMember = nameof(dataSet1.DataTable1);

            dgv1.DataSource = bindingSource1;
            dgv2.DataSource = bindingSource1;

            dgv1.Columns.Insert(1, new DataGridViewTextBoxColumn());
            dgv2.Columns.Insert(1, new DataGridViewTextBoxColumn());
        }
    }
}
