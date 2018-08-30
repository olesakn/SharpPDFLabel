using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPDFLabel.Labels.LetterLabels
{
    // For convenience, provide specific label versions
    public class L5167 : L1_75x0_5 { }
    public class L8167 : L1_75x0_5 { }

    /// <summary>
    /// Size: 1.75" x 0.5"
    /// Labels per sheet: 80
    /// Includes: Avery 5167, 8167
    /// Intended use: Popular return address label size. General uses. Marking, Deli container labeling, File Folder
    /// Spec Source: https://www.worldlabel.com/Templates/wl-ol25Word.htm
    /// </summary>
    public class L1_75x0_5 : LabelDefinition
    {
        public L1_75x0_5()
        {
            _Width = 44.45;
            _Height = 12.7;
            _HorizontalGapWidth = 7.14375;
            _VerticalGapHeight = 0;

            _PageMarginTop = 12.7;
            _PageMarginBottom = 12.7;
            _PageMarginLeft = 8.382;
            _PageMarginRight = 8.382;

            PageSize = Enums.PageSize.Letter;
            LabelsPerRow = 4;
            LabelRowsPerPage = 20;
        }
    }
}
