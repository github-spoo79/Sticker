using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAESticker.VO
{
    public class StickerVO
    {
        private string iudFlag;
        private string formId;
        private int posX;
        private int posY;
        private int formWidth;
        private int formHeight;
        private int formPrevWidth;
        private int formPrevHeight;
        private int formOpacity;
        private string title;
        private string contents;
        private string contentsRtf;
        private string delYn;
        private string delDt;
        private string hiddenYn;
        private string foldYn;
        private string fixedYn;
        private string rgstDt;
        private string updtDt;

        public string IudFlag
        {
            get { return iudFlag; }
            set { iudFlag = value; }
        }

        public string FormId
        {
            get { return formId; }
            set { formId = value; }
        }

        public int PosX
        {
            get { return posX; }
            set { posX = value; }
        }

        public int PosY
        {
            get { return posY; }
            set { posY = value; }
        }

        public int FormWidth
        {
            get { return formWidth; }
            set { formWidth = value; }
        }

        public int FormHeight
        {
            get { return formHeight; }
            set { formHeight = value; }
        }

        public int FormPrevWidth
        {
            get { return formPrevWidth; }
            set { formPrevWidth = value; }
        }

        public int FormPrevHeight
        {
            get { return formPrevHeight; }
            set { formPrevHeight = value; }
        }

        public int FormOpacity
        {
            get { return formOpacity; }
            set { formOpacity = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Contents
        {
            get { return contents; }
            set { contents = value; }
        }
        
        public string ContentsRtf
        {
            get { return contentsRtf; }
            set { contentsRtf = value; }
        }

        public string DelYn
        {
            get { return delYn; }
            set { delYn = value; }
        }

        public string DelDt
        {
            get { return delDt; }
            set { delDt = value; }
        }

        public string HiddenYn
        {
            get { return hiddenYn; }
            set { hiddenYn = value; }
        }

        public string FoldYn
        {
            get { return foldYn; }
            set { foldYn = value; }
        }

        public string FixedYn
        {
            get { return fixedYn; }
            set { fixedYn = value; }
        }

        public string RgstDt
        {
            get { return rgstDt; }
            set { rgstDt = value; }
        }

        public string UpdtDt
        {
            get { return updtDt; }
            set { updtDt = value; }
        }
    }
}
