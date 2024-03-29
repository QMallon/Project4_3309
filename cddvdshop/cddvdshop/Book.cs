﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Quinn Mallon
 Abu Syed
book class
     */
namespace cddvdshop
{
    [Serializable()]
    class Book: Product
    {

        private int hiddenISBNleft;
        private int hiddenISBNright;
        private string hiddenAuthor;
        private int hiddenPages;
        
        public Book()
        {

        }
        public Book(int UPC, decimal price, string title, int quantity,int ISBNleft, int ISBNright, string author, int pages):base(UPC,price,title,quantity)
        {
            hiddenISBNleft = ISBNleft;
            hiddenISBNright = ISBNright;
            hiddenAuthor = author;
            hiddenPages = pages;

        }
        //getters for isbn left and rguith
        public int getISBNL()
        {
            return hiddenISBNleft;
        }
        public int getISBNR()
        {
            return hiddenISBNright;
        }
        //save
        public override void Save(frmBookCDDVDShop f)
        {
            base.Save(f);
            hiddenISBNleft = Convert.ToInt32(f.txtBookISBNLeft.Text);
            hiddenISBNright = Convert.ToInt32(f.txtBookISBNRight.Text);
            hiddenAuthor = f.txtBookAuthor.Text;
            hiddenPages = Convert.ToInt32(f.txtBookPages.Text);
        }  // end Save
        //display
        public override void Display(frmBookCDDVDShop f)
        {
            base.Display(f);
            f.txtBookAuthor.Text = hiddenAuthor;
            f.txtBookISBNLeft.Text = hiddenISBNleft.ToString();
            f.txtBookISBNRight.Text = hiddenISBNright.ToString();
            f.txtBookPages.Text = hiddenPages.ToString();
        }
        //tpStriong
        public override string ToString()
        {
            string s =  base.ToString();
            s += "Book ISBN :" + hiddenISBNleft.ToString() + hiddenISBNright.ToString() + "\n";
            s += "Book Author :" + hiddenAuthor + "\n";
            s += "Book Pages :" + hiddenPages + "\n";
            return s;
        }

    }
}
