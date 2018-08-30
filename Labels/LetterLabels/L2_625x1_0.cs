using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpPDFLabel.Labels.LetterLabels.Avery
{
    // For convenience, provide specific label versions
    public class L5160 : L2_625x1_0 { }
    public class L5260 : L2_625x1_0 { }
    public class L5520 : L2_625x1_0 { }
    public class L5660 : L2_625x1_0 { }
    public class L5810 : L2_625x1_0 { }
    public class L5960 : L2_625x1_0 { }
    public class L5970 : L2_625x1_0 { }
    public class L5971 : L2_625x1_0 { }
    public class L5972 : L2_625x1_0 { }
    public class L5979 : L2_625x1_0 { }
    public class L5980 : L2_625x1_0 { }
    public class L8160 : L2_625x1_0 { }
    public class L8460 : L2_625x1_0 { }
    public class L8660 : L2_625x1_0 { }
    public class L8810 : L2_625x1_0 { }


    /// <summary>
    /// Size: 2.625" x 1"
    /// Labels per sheet: 30
    /// Includes: Avery® 5160®, 5260™, 5520™, 5660®, 5810™, 5960™, 5970™, 5971™ , 5972™, 5979™, 5980™, 8160™, 8460™, 8660™, 8810™
    /// Intended use: Standard Address Labels, Mailing Labels
    /// Spec Source: https://www.worldlabel.com/Templates/wl-ol875Word.htm
    /// </summary>
    public class L2_625x1_0 : LabelDefinition
    {
        public L2_625x1_0()
        {
            _Width = 215.9;
            _Height = 279.4;
            _HorizontalGapWidth = 3.556;
            _VerticalGapHeight = 0;

            _PageMarginTop = 12.7;
            _PageMarginBottom = 12.7;
            _PageMarginLeft = 5.58165;
            _PageMarginRight = 5.58165;

            PageSize = Enums.PageSize.Letter;
            LabelsPerRow = 3;
            LabelRowsPerPage = 10;
        }
    }

}