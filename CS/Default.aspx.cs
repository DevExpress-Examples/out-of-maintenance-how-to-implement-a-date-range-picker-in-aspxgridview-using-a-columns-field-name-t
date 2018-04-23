using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        grid.DataSource = Enumerable.Range(0, 10).Select(x => new SomeData { ProductID = x, StartDate = DateTime.Now, EndDate = DateTime.Now });
        grid.DataBind();
    }
    protected void grid_RowUpdating(object sender, DevExpress.Web.Data.	ASPxDataUpdatingEventArgs e) {
		e.Cancel = true;
	}
	protected void grid_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e) {
		e.Cancel = true;
	}
	protected void grid_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e) {
		e.Cancel = true;
	}
	
}
public class SomeData
{
    public int ProductID { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}