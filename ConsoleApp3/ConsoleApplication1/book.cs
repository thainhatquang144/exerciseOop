
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class book
    {
        private string name;
        private double Price;
        private author []authors;
        private int Qty;

        public book(string name,author[] authors,double price)
        {
            this.authors= authors;
            this.name = name;
            this.Price = price;
            this.Qty = 0;
        }

      
        public string getName()
        {
            return this.name;
        }
        public author[] getAuthor()
        {
            return authors;
        }
        public double getPrice()
        {
            return this.Price;
        }
       public int getQty()
        {
            return this.Qty;
        }
        public void setPrice(double price)
        {
            this.Price = price;
        }public void setqty(int qty){
            this.Qty=qty;
        }
        //public override string ToString()
        //{
        //    string authors = "";
        //    for (int i = 0; i < this.authors.Length; i++)
        //        authors += this.authors[i].ToString();
        //        return String.Format("Book[name={0},authors{{{3}}},price={1},qty={2}",
        //            this.name, this.Price, this.Qty, this.authors);
        //}
        public override string ToString()
        {
            string authors = " ";
            for (int i = 0; i < this.authors.Length; i++)
                authors += this.authors[i].ToString() + ",";
            return String.Format("Book[name={0},{{{3}}},price={1},qty={2}]",
                this.name, this.Price, this.Qty, authors);
        }
  
    }
}
