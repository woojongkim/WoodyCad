using System;

namespace WoodyCad
{
    public class DrawingBase
    {
        private long DrawingId { get; set; }
        private string DrawingNo { get; set; }
        private string DrawingName { get; set; }
        private long Revision { get; set; }
        private string Comment { get; set; }
        private string Drafter { get; set; }
        private string FileName { get; set; }
        private DateTime CreateDate { get; set; }
    }
}