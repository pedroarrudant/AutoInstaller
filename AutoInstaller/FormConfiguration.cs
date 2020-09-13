using AI.Application;
using AI.Infrastructure.IoC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace AutoInstaller
{
    public partial class FormConfiguration : Form
    {
        private IDownload _appDownload;
        private IInstall _appInstall;

        public FormConfiguration()
        {
            InitializeComponent();

            IUnityContainer container = new UnityContainer();
            container.RegisterType<IInfrastructureFactory, InfrastructureFactory>();

            _appDownload = container.Resolve<Download>();
            _appInstall = container.Resolve<Install>();
        }
    }
}
