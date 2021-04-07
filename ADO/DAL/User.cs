using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ADO.DAL
{
    public class User : IBindableComponent
    {
        ISite iSite;
        ControlBindingsCollection dataBindings;
        BindingContext bindingContext = new BindingContext();
        
        public User()
        {
            dataBindings = new ControlBindingsCollection(this);
        }
        [Browsable(false)]
        public event EventHandler Disposed;
        [Browsable(false)]
        public void Dispose()
        {

        }
        [Browsable(false)]
        public BindingContext BindingContext
        {
            get { return bindingContext;  }
            set { bindingContext = value; }
        }
        [Browsable(false)]
        public ControlBindingsCollection DataBindings
        {
            get { return dataBindings; }
        }
        [Browsable(false)]
        public ISite Site
        {
            get { return iSite; }
            set { iSite = value; }
        }



        [DisplayName("ID")]
        public int Id { get; set; }
        [DisplayName("Username")]
        public string UserName { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }
}