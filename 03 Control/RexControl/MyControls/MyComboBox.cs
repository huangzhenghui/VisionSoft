// Decompiled with JetBrains decompiler
// Type: Rex.UI.UIComboBox
// Assembly: RexUI, Version=2.2.8.0, Culture=neutral, PublicKeyToken=null
// MVID: 7B692304-90C7-4106-B5F4-59B900FD7D6E
// Assembly location: C:\Users\MECHREVO\Desktop\RexUI.dll

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;

namespace Rex.UI
{
  [DefaultProperty("Items")]
  [DefaultEvent("SelectedIndexChanged")]
  [ToolboxItem(true)]
  [LookupBindingProperties("DataSource", "DisplayMember", "ValueMember", "SelectedValue")]
  public sealed class MyComboBox : DropControl
  {
    public readonly ComboBox box = new ComboBox();
    private readonly UIComboBoxItem dropForm = new UIComboBoxItem();
    private IContainer components = (IContainer) null;
    private object dataSource;
    private bool inSetDataConnection;
    private CurrencyManager dataManager;
    private object selectedValue;

    [DefaultValue(8)]
    [Description("列表下拉最大个数")]
    [Category("Rex")]
    public int MaxDropDownItems { get; set; } = 8;

    private UIListBox ListBox
    {
      get
      {
        return this.dropForm.ListBox;
      }
    }

    [DefaultValue(25)]
    [Description("列表项高度")]
    [Category("Rex")]
    public int ItemHeight
    {
      get
      {
        return this.ListBox.ItemHeight;
      }
      set
      {
        this.ListBox.ItemHeight = value;
      }
    }

    [DefaultValue(null)]
    [RefreshProperties(RefreshProperties.Repaint)]
    [AttributeProvider(typeof (IListSource))]
    [Description("数据源")]
    [Category("Rex")]
    public object DataSource
    {
      get
      {
        return this.dataSource;
      }
      set
      {
        this.SetDataConnection(value, new BindingMemberInfo(this.DisplayMember));
        this.dataSource = value;
        this.box.Items.Clear();
        if (this.dataManager == null)
          return;
        foreach (object obj in (IEnumerable) this.dataManager.List)
          this.box.Items.Add(obj);
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof (UITypeEditor))]
    [Localizable(true)]
    [MergableProperty(false)]
    [Description("下拉显示项")]
    [Category("Rex")]
    public ComboBox.ObjectCollection Items
    {
      get
      {
        return this.box.Items;
      }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Description("选中索引")]
    [Category("Rex")]
    public int SelectedIndex
    {
      get
      {
        return this.box.SelectedIndex;
      }
      set
      {
        this.box.SelectedIndex = value;
      }
    }

    [Browsable(false)]
    [Bindable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Description("选中项")]
    [Category("Rex")]
    public object SelectedItem
    {
      get
      {
        return this.box.SelectedItem;
      }
      set
      {
        this.box.SelectedItem = value;
      }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Description("选中文字")]
    [Category("Rex")]
    public string SelectedText
    {
      get
      {
        if (this.DropDownStyle == UIDropDownStyle.DropDown)
          return this.edit.SelectedText;
        return this.Text;
      }
    }

    [Description("获取或设置要为此列表框显示的属性。")]
    [Category("Rex")]
    [DefaultValue("")]
    [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof (UITypeEditor))]
    [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public string DisplayMember
    {
      get
      {
        return this.box.DisplayMember;
      }
      set
      {
        this.SetDataConnection(this.dataSource, new BindingMemberInfo(value));
        this.box.DisplayMember = value;
      }
    }

    [Description("获取或设置指示显示值的方式的格式说明符字符。")]
    [Category("Rex")]
    [DefaultValue("")]
    [Editor("System.Windows.Forms.Design.FormatStringEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof (UITypeEditor))]
    [MergableProperty(false)]
    public string FormatString
    {
      get
      {
        return this.box.FormatString;
      }
      set
      {
        this.box.FormatString = value;
      }
    }

    [Description("获取或设置指示显示值是否可以进行格式化操作。")]
    [Category("Rex")]
    [DefaultValue(false)]
    public bool FormattingEnabled
    {
      get
      {
        return this.box.FormattingEnabled;
      }
      set
      {
        this.box.FormattingEnabled = value;
      }
    }

    [Description("获取或设置要为此列表框实际值的属性。")]
    [Category("Rex")]
    [DefaultValue("")]
    [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof (UITypeEditor))]
    public string ValueMember
    {
      get
      {
        return this.box.ValueMember;
      }
      set
      {
        this.box.ValueMember = value;
      }
    }

    [DefaultValue(null)]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Bindable(true)]
    public object SelectedValue
    {
      get
      {
        this.GetSelectedValue();
        return this.selectedValue;
      }
      set
      {
        this.selectedValue = value;
        if (value == null || this.dataManager == null)
          return;
        this.SelectedIndex = this.DataManagerFind(value);
      }
    }

    public event EventHandler SelectedIndexChanged;

    public event EventHandler DataSourceChanged;

    public event EventHandler DisplayMemberChanged;

    public event EventHandler ValueMemberChanged;

    public event EventHandler SelectedValueChanged;

    public MyComboBox()
    {
      this.InitializeComponent();
      this.box.SelectedIndexChanged += new EventHandler(this.Box_SelectedIndexChanged);
      this.box.DataSourceChanged += new EventHandler(this.Box_DataSourceChanged);
      this.box.DisplayMemberChanged += new EventHandler(this.Box_DisplayMemberChanged);
      this.box.ValueMemberChanged += new EventHandler(this.Box_ValueMemberChanged);
      this.ListBox.Font = this.Font;
      this.ListBox.ForeColor = this.ForeColor;
      this.ListBox.RectColor = this.FillColor;
    }

    private void Box_ValueMemberChanged(object sender, EventArgs e)
    {
      EventHandler eventHandler = this.ValueMemberChanged;
      if (eventHandler == null)
        return;
      object sender1 = sender;
      EventArgs e1 = e;
      eventHandler(sender1, e1);
    }

    private void Box_DisplayMemberChanged(object sender, EventArgs e)
    {
      EventHandler eventHandler = this.DisplayMemberChanged;
      if (eventHandler == null)
        return;
      object sender1 = sender;
      EventArgs e1 = e;
      eventHandler(sender1, e1);
    }

    private void Box_DataSourceChanged(object sender, EventArgs e)
    {
      EventHandler eventHandler = this.DataSourceChanged;
      if (eventHandler == null)
        return;
      object sender1 = sender;
      EventArgs e1 = e;
      eventHandler(sender1, e1);
    }

    private void Box_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.Text = this.box.GetItemText(this.box.SelectedItem);
      this.GetSelectedValue();
      EventHandler eventHandler1 = this.SelectedValueChanged;
      if (eventHandler1 != null)
      {
        EventArgs e1 = e;
        eventHandler1((object) this, e1);
      }
      EventHandler eventHandler2 = this.SelectedIndexChanged;
      if (eventHandler2 == null)
        return;
      EventArgs e2 = e;
      eventHandler2((object) this, e2);
    }

    protected override void ItemForm_ValueChanged(object sender, object value)
    {
      this.SelectedIndex = this.ListBox.SelectedIndex;
      this.Invalidate();
    }

    protected override void CreateInstance()
    {
      this.ItemForm = new UIDropDown((UIDropDownItem)this.dropForm);
    }

    protected override int CalcItemFormHeight()
    {
      return 4 + Math.Min(this.ListBox.Items.Count, this.MaxDropDownItems) * this.ItemHeight + (this.ItemForm.Height - this.ItemForm.ClientRectangle.Height);
    }

    private void UIComboBox_FontChanged(object sender, EventArgs e)
    {
      if (this.ItemForm == null)
        return;
      this.ListBox.Font = this.Font;
    }

    private void UIComboBox_ButtonClick(object sender, EventArgs e)
    {
      this.ListBox.Items.Clear();
      if (this.Items.Count == 0 || this.ItemForm.Visible)
        return;
      foreach (object obj in this.Items)
        this.ListBox.Items.Add((object) this.GetItemText(obj));
      this.ListBox.SelectedIndex = this.SelectedIndex;
      this.ItemForm.Show((Control) this, new Size(this.Width, this.CalcItemFormHeight()));
    }

    public override void SetStyleColor(UIBaseStyle uiColor)
    {
      base.SetStyleColor(uiColor);
      if (UIStyleHelper.IsCustom(uiColor))
        return;
      this.ListBox.SetStyleColor(uiColor);
    }

    private void SetDataConnection(object newDataSource, BindingMemberInfo newDisplayMember)
    {
      bool flag1 = this.dataSource != newDataSource;
      bool flag2 = !this.DisplayMember.Equals(newDisplayMember.BindingPath);
      if (this.inSetDataConnection)
        return;
      try
      {
        this.inSetDataConnection = true;
        if (!(flag1 | flag2))
          return;
        CurrencyManager currencyManager = (CurrencyManager) null;
        if (newDataSource != null && newDataSource != Convert.DBNull)
          currencyManager = (CurrencyManager) this.BindingContext[newDataSource, newDisplayMember.BindingPath];
        this.dataManager = currencyManager;
      }
      finally
      {
        this.inSetDataConnection = false;
      }
    }

    public override void ResetText()
    {
      this.Clear();
    }

    private void GetSelectedValue()
    {
      if (this.SelectedIndex != -1 && this.dataManager != null)
        this.selectedValue = this.FilterItemOnProperty(this.SelectedItem, this.ValueMember);
      else
        this.selectedValue = (object) null;
    }

    private int DataManagerFind(object value)
    {
      if (this.dataManager == null)
        return -1;
      for (int index = 0; index < this.dataManager.List.Count; ++index)
      {
        if (this.FilterItemOnProperty(this.dataManager.List[index], this.ValueMember).Equals(value))
          return index;
      }
      return -1;
    }

    private object FilterItemOnProperty(object item, string field)
    {
      if (item != null && field.Length > 0)
      {
        try
        {
          PropertyDescriptor propertyDescriptor = this.dataManager == null ? TypeDescriptor.GetProperties(item).Find(field, true) : this.dataManager.GetItemProperties().Find(field, true);
          if (propertyDescriptor != null)
            item = propertyDescriptor.GetValue(item);
        }
        catch
        {
          return (object) null;
        }
      }
      return item;
    }

    public string GetItemText(object item)
    {
      return this.box.GetItemText(item);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.SuspendLayout();
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.AliceBlue;
            this.edit.Font = new System.Drawing.Font("华文新魏", 11.5F);
            this.edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.edit.Size = new System.Drawing.Size(163, 16);
            // 
            // MyComboBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.FillColor = System.Drawing.Color.AliceBlue;
            this.Font = new System.Drawing.Font("华文新魏", 11.5F);
            this.Name = "MyComboBox";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.Radius = 2;
            this.RectColor = System.Drawing.Color.CornflowerBlue;
            this.Size = new System.Drawing.Size(193, 23);
            this.SymbolDropDown = 61656;
            this.SymbolNormal = 61655;
            this.ButtonClick += new System.EventHandler(this.UIComboBox_ButtonClick);
            this.FontChanged += new System.EventHandler(this.UIComboBox_FontChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
  }
}
