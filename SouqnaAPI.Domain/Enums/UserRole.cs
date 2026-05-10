using System;
using System.Collections.Generic;
using System.Text;

namespace SouqnaAPI.Domain.Enums;

public enum UserRole { Admin, Seller, Customer }
public enum SellerStatus { Pending, Active, Suspended }
public enum OrderStatus { Pending, Confirmed, Delivered, Cancelled }