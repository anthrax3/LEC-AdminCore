﻿/* Copyright (C) Grupo Kyoka SAS - All Rights Reserved. Proprietary and confidential.
 * Unauthorized copying of this file, via any medium is strictly prohibited.  
 * File Author:     Felipe Suarez <suarez.a.felipe@gmail.com>
 * Date Created:    November 2017
 * Description:     Abstraction of the Database Context for a specific business domain.
 *                  See the implementation comments of this interface for more details.
 *                  For more information Google: "Interfaces", "Dependency Injection"
 */

using AdminCore.BusinessLogic.Products.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminCore.Persistence.Domain.Products
{
    public interface IProductContext
    {
        DbSet<Brand> Brands { get; set; }

    }
}
