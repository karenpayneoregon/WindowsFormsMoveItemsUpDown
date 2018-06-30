using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CommonLangageExtensionsLibrary;
using DataBackEnd;

namespace MainApplication
{
    public partial class DataGridViewNoRememberForm : Form
    {

        #region Drag and Drop logic properties
        private Rectangle _dragBoxFromMouseDown;
        private int _rowIndexFromMouseDown;
        private int _rowIndexOfItemUnderMouseToDrop;
        #endregion


        /// <summary>
        /// This is the field in the database table that hold the 
        /// position a record will be displayed
        /// </summary>
        private Operations _ops = new Operations();
        public DataGridViewNoRememberForm()
        {
            InitializeComponent();
            Shown += DataGridViewNoRememberForm_Shown;
            dataGridView1.MouseMove += DataGridView1_MouseMove;
            dataGridView1.MouseDown += DataGridView1_MouseDown;
            dataGridView1.DragDrop += DataGridView1_DragDrop;
            dataGridView1.DragOver += DataGridView1_DragOver;
            
        }

        #region Drag and Drop logic
        private void DataGridView1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void DataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            Point clientPoint = dataGridView1.PointToClient(new Point(e.X, e.Y));

            _rowIndexOfItemUnderMouseToDrop =
                dataGridView1.HitTest(clientPoint.X, clientPoint.Y).RowIndex;


            if (e.Effect == DragDropEffects.Move)
            {
                DataGridViewRow rowToMove = e.Data.GetData(
                    typeof(DataGridViewRow)) as DataGridViewRow;
                dataGridView1.Rows.RemoveAt(_rowIndexFromMouseDown);
                dataGridView1.Rows.Insert(_rowIndexOfItemUnderMouseToDrop, rowToMove);

            }
        }

        private void DataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            _rowIndexFromMouseDown = dataGridView1.HitTest(e.X, e.Y).RowIndex;
            if (_rowIndexFromMouseDown != -1)
            {
                var dragSize = SystemInformation.DragSize;

                _dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                    e.Y - (dragSize.Height / 2)),
                    dragSize);
            }
            else
                _dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void DataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                if (_dragBoxFromMouseDown != Rectangle.Empty &&
                    !_dragBoxFromMouseDown.Contains(e.X, e.Y))
                {

                    // ReSharper disable once UnusedVariable
                    var dropEffect = dataGridView1.DoDragDrop(
                        dataGridView1.Rows[_rowIndexFromMouseDown],
                        DragDropEffects.Move);
                }
            }
        }
        #endregion

        private void DataGridViewNoRememberForm_Shown(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            var dt = _ops.LoadProductsByCategory(true);

            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(row.Field<int>("Id"), row.Field<string>("Name"));
            }

            dataGridView1.ExpandColumns();

        }
        private void upButton_Click(object sender, EventArgs e)
        {
            dataGridView1.MoveRowUp();
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            dataGridView1.MoveRowDown();
        }
        /// <summary>
        /// Basic confirmation/validation the rows in the DataGridView
        /// have been properly reordered.
        /// 
        /// For a real application we might export data to a text file
        /// or another file type.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdValidate_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.OfType<DataGridViewRow>()
                .Select(row => new
                {
                    row.Index,
                    Value = Convert.ToString(row.Cells["nameColumn"].Value)
                })
                .ToList()
                .ForEach(item => Console.WriteLine($"{item.Index,-4} {item.Value}"));
        }
        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
