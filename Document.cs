using iTextSharp.text;
using System;

namespace EmployeeManagementSystem
{
    internal class Document
    {
        private Rectangle a4;
        private int v1;
        private int v2;
        private int v3;
        private int v4;

        public Document(Rectangle a4, int v1, int v2, int v3, int v4)
        {
            this.a4 = a4;
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        internal void Add(Paragraph paragraph)
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}