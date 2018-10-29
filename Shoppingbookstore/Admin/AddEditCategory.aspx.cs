﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoppingHeart.BusinessLayer;

namespace ShoppingHeart.Admin
{
    public partial class AddEditCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This event is fired when admin wants to add a NEW Category
        /// Here we are only adding CategoryName
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ShoppingCart k = new ShoppingCart
            {
                CategoryName=txtCategoryName.Text
            };
            k.AddNewCategory();
            txtCategoryName.Text = string.Empty;
            Response.Redirect("~/Admin/AddNewProducts.aspx");
        }
    }
}
