using System;
using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;

namespace KGKMarkingStudio.Model;

/// <summary>
/// 表示联系人的模型类，使用MVVM模式实现
/// </summary>
public partial class Contact : ObservableObject
{
    /// <summary>
    /// 联系人ID
    /// </summary>
    [ObservableProperty]
    private Guid _id = Guid.NewGuid();
    
    /// <summary>
    /// 联系人姓名
    /// </summary>
    [ObservableProperty]
    private string _name = string.Empty;
    
    /// <summary>
    /// 联系人电话
    /// </summary>
    [ObservableProperty]
    private string _phoneNumber = string.Empty;
    
    /// <summary>
    /// 联系人邮箱
    /// </summary>
    [ObservableProperty]
    private string _email = string.Empty;
    
    /// <summary>
    /// 联系人地址
    /// </summary>
    [ObservableProperty]
    private string _address = string.Empty;
    
    /// <summary>
    /// 创建时间
    /// </summary>
    [ObservableProperty]
    private DateTime _createdAt = DateTime.Now;
    
    /// <summary>
    /// 联系人分组
    /// </summary>
    [ObservableProperty]
    private string _group = string.Empty;
}