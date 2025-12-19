<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        MenuStrip1 = New MenuStrip()
        MastersToolStripMenuItem = New ToolStripMenuItem()
        mnuProducts = New ToolStripMenuItem()
        mnuProductList = New ToolStripMenuItem()
        mnuAddProduct = New ToolStripMenuItem()
        SuppliersToolStripMenuItem = New ToolStripMenuItem()
        InventoryToolStripMenuItem = New ToolStripMenuItem()
        mnuInventoryTxn = New ToolStripMenuItem()
        mnuInventoryHistory = New ToolStripMenuItem()
        mnuReorder = New ToolStripMenuItem()
        PurchaseToolStripMenuItem = New ToolStripMenuItem()
        mnuCreatePO = New ToolStripMenuItem()
        mnuReceivePO = New ToolStripMenuItem()
        mnuPOList = New ToolStripMenuItem()
        mnuExit = New ToolStripMenuItem()
        ReportsToolStripMenuItem = New ToolStripMenuItem()
        mnuLowStockReport = New ToolStripMenuItem()
        AddUpdateSupplierToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(253, 96)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 38)
        Label1.TabIndex = 0
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {MastersToolStripMenuItem, InventoryToolStripMenuItem, PurchaseToolStripMenuItem, mnuExit, ReportsToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(10, 3, 0, 3)
        MenuStrip1.Size = New Size(1462, 35)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MastersToolStripMenuItem
        ' 
        MastersToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuProducts, SuppliersToolStripMenuItem})
        MastersToolStripMenuItem.Name = "MastersToolStripMenuItem"
        MastersToolStripMenuItem.Size = New Size(90, 29)
        MastersToolStripMenuItem.Text = "Masters"
        ' 
        ' mnuProducts
        ' 
        mnuProducts.DropDownItems.AddRange(New ToolStripItem() {mnuProductList, mnuAddProduct})
        mnuProducts.Name = "mnuProducts"
        mnuProducts.Size = New Size(270, 34)
        mnuProducts.Text = "Products"
        ' 
        ' mnuProductList
        ' 
        mnuProductList.Name = "mnuProductList"
        mnuProductList.Size = New Size(215, 34)
        mnuProductList.Text = "Product List"
        ' 
        ' mnuAddProduct
        ' 
        mnuAddProduct.Name = "mnuAddProduct"
        mnuAddProduct.Size = New Size(215, 34)
        mnuAddProduct.Text = "Add Product"
        ' 
        ' SuppliersToolStripMenuItem
        ' 
        SuppliersToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddUpdateSupplierToolStripMenuItem})
        SuppliersToolStripMenuItem.Name = "SuppliersToolStripMenuItem"
        SuppliersToolStripMenuItem.Size = New Size(270, 34)
        SuppliersToolStripMenuItem.Text = "Suppliers"
        ' 
        ' InventoryToolStripMenuItem
        ' 
        InventoryToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuInventoryTxn, mnuInventoryHistory, mnuReorder})
        InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        InventoryToolStripMenuItem.Size = New Size(103, 29)
        InventoryToolStripMenuItem.Text = "Inventory"
        ' 
        ' mnuInventoryTxn
        ' 
        mnuInventoryTxn.Name = "mnuInventoryTxn"
        mnuInventoryTxn.Size = New Size(279, 34)
        mnuInventoryTxn.Text = "Stock(IN\OUT)"
        ' 
        ' mnuInventoryHistory
        ' 
        mnuInventoryHistory.Name = "mnuInventoryHistory"
        mnuInventoryHistory.Size = New Size(279, 34)
        mnuInventoryHistory.Text = "Inventory History"
        ' 
        ' mnuReorder
        ' 
        mnuReorder.Name = "mnuReorder"
        mnuReorder.Size = New Size(279, 34)
        mnuReorder.Text = "Reorder Suggestions"
        ' 
        ' PurchaseToolStripMenuItem
        ' 
        PurchaseToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuCreatePO, mnuReceivePO, mnuPOList})
        PurchaseToolStripMenuItem.Name = "PurchaseToolStripMenuItem"
        PurchaseToolStripMenuItem.Size = New Size(98, 29)
        PurchaseToolStripMenuItem.Text = "Purchase"
        ' 
        ' mnuCreatePO
        ' 
        mnuCreatePO.Name = "mnuCreatePO"
        mnuCreatePO.Size = New Size(290, 34)
        mnuCreatePO.Text = "Create Purchase Order"
        ' 
        ' mnuReceivePO
        ' 
        mnuReceivePO.Name = "mnuReceivePO"
        mnuReceivePO.Size = New Size(290, 34)
        mnuReceivePO.Text = "Receive Goods"
        ' 
        ' mnuPOList
        ' 
        mnuPOList.Name = "mnuPOList"
        mnuPOList.Size = New Size(290, 34)
        mnuPOList.Text = "Purchase Order List"
        ' 
        ' mnuExit
        ' 
        mnuExit.Name = "mnuExit"
        mnuExit.Size = New Size(55, 29)
        mnuExit.Text = "Exit"
        ' 
        ' ReportsToolStripMenuItem
        ' 
        ReportsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuLowStockReport})
        ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        ReportsToolStripMenuItem.Size = New Size(89, 29)
        ReportsToolStripMenuItem.Text = "Reports"
        ' 
        ' mnuLowStockReport
        ' 
        mnuLowStockReport.Name = "mnuLowStockReport"
        mnuLowStockReport.Size = New Size(270, 34)
        mnuLowStockReport.Text = "Low Stock Report"
        ' 
        ' AddUpdateSupplierToolStripMenuItem
        ' 
        AddUpdateSupplierToolStripMenuItem.Name = "AddUpdateSupplierToolStripMenuItem"
        AddUpdateSupplierToolStripMenuItem.Size = New Size(283, 34)
        AddUpdateSupplierToolStripMenuItem.Text = "Add/Update Supplier"
        ' 
        ' DashboardForm
        ' 
        AutoScaleDimensions = New SizeF(17F, 38F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1462, 684)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MainMenuStrip = MenuStrip1
        Margin = New Padding(5)
        Name = "DashboardForm"
        Text = "Inventory & Purchase Management System"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MastersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuProducts As ToolStripMenuItem
    Friend WithEvents SuppliersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuInventoryTxn As ToolStripMenuItem
    Friend WithEvents mnuInventoryHistory As ToolStripMenuItem
    Friend WithEvents mnuReorder As ToolStripMenuItem
    Friend WithEvents PurchaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuCreatePO As ToolStripMenuItem
    Friend WithEvents mnuReceivePO As ToolStripMenuItem
    Friend WithEvents mnuPOList As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuProductList As ToolStripMenuItem
    Friend WithEvents mnuAddProduct As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuLowStockReport As ToolStripMenuItem
    Friend WithEvents AddUpdateSupplierToolStripMenuItem As ToolStripMenuItem
End Class
