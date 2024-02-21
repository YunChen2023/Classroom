using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    internal class Cell : IComparable<Cell>
    {
        private int columnID;
        private int rowID;
        private string cellContent;
        private string cellColor;

        public int ColumnID { get; set; }
        public int RowID { get; set; }
        public string CellContent { get; set; }
        public string CellColor { get; set; }

        public Cell (int columnID, int rowID, string cellContent, string cellColor)
        {
            ColumnID = columnID;
            RowID = rowID;  
            CellContent = cellContent;
            CellColor = cellColor;
        }

        public int CompareTo (Cell other)
        {
            return CellContent.CompareTo(other.CellContent);
        }

        public override string ToString()
        {
            return ColumnID + "," + RowID + "," + CellContent + "," + CellColor;
           
        }
    }
}
