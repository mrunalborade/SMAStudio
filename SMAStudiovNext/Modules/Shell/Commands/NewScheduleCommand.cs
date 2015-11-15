﻿using Caliburn.Micro;
using Gemini.Framework.Services;
using SMAStudiovNext.Models;
using SMAStudiovNext.Modules.EnvironmentExplorer.ViewModels;
using SMAStudiovNext.Modules.Schedule.ViewModels;
using System;
using System.Windows.Input;

namespace SMAStudiovNext.Modules.Shell.Commands
{
    public class NewScheduleCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var shell = IoC.Get<IShell>();

            var context = IoC.Get<EnvironmentExplorerViewModel>().GetCurrentContext();
            var viewModel = new ScheduleViewModel(new ScheduleModelProxy(new SMA.OneTimeSchedule(), context));

            shell.OpenDocument(viewModel);
        }
    }
}