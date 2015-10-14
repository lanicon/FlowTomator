﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

using FlowTomator.Common;

namespace FlowTomator.Desktop
{
    public class EditorTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FlowInfo flowInfo = item as FlowInfo;
            Type flowType = flowInfo.Type;

            Type editorType = Assembly.GetExecutingAssembly().GetTypes()
                                                             .Where(t => t.GetCustomAttribute<EditorAttribute>() != null)
                                                             .FirstOrDefault(t => t.GetCustomAttribute<EditorAttribute>().Types.Contains(flowType));

            DataTemplate dataTemplate = new DataTemplate();
            dataTemplate.VisualTree = new FrameworkElementFactory(editorType);

            return dataTemplate;
        }
    }
}