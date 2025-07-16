## Open source Personal Expense Tracker app
### Folder structure 
```
PersonalExpenseTracker/
    ├── src/
    │   ├── PersonalExpenseTracker.API/          # Web API project
    │   │   ├── Controllers/
    │   │   │   ├── ExpensesController.cs
    │   │   │   ├── CategoriesController.cs
    │   │   │   ├── BudgetsController.cs
    │   │   │   ├── ReportsController.cs
    │   │   │   └── AuthController.cs
    │   │   ├── Program.cs
    │   │   ├── appsettings.json
    │   │   ├── appsettings.Development.json
    │   │   └── PersonalExpenseTracker.API.csproj
    │   │
    │   ├── PersonalExpenseTracker.Web/          # MVC project
    │   │   ├── Controllers/
    │   │   │   ├── HomeController.cs
    │   │   │   ├── ExpenseController.cs
    │   │   │   ├── CategoryController.cs
    │   │   │   └── BudgetController.cs
    │   │   ├── Views/
    │   │   │   ├── Shared/
    │   │   │   ├── Home/
    │   │   │   ├── Expense/
    │   │   │   ├── Category/
    │   │   │   └── Budget/
    │   │   ├── wwwroot/
    │   │   │   ├── css/
    │   │   │   ├── js/
    │   │   │   └── lib/
    │   │   ├── Program.cs
    │   │   ├── appsettings.json
    │   │   └── PersonalExpenseTracker.Web.csproj
    │   │
    │   ├── PersonalExpenseTracker.Core/         # Business logic &
    interfaces
    │   │   ├── Entities/
    │   │   │   ├── Expense.cs
    │   │   │   ├── Category.cs
    │   │   │   ├── Budget.cs
    │   │   │   └── User.cs
    │   │   ├── DTOs/
    │   │   │   ├── ExpenseDto.cs
    │   │   │   ├── CategoryDto.cs
    │   │   │   └── BudgetDto.cs
    │   │   ├── Interfaces/
    │   │   │   ├── IExpenseService.cs
    │   │   │   ├── ICategoryService.cs
    │   │   │   └── IBudgetService.cs
    │   │   ├── Services/
    │   │   │   ├── ExpenseService.cs
    │   │   │   ├── CategoryService.cs
    │   │   │   └── BudgetService.cs
    │   │   └── PersonalExpenseTracker.Core.csproj
    │   │
    │   └── PersonalExpenseTracker.Data/         # Data access layer
    │       ├── Context/
    │       │   └── ExpenseTrackerDbContext.cs
    │       ├── Repositories/
    │       │   ├── IRepository.cs
    │       │   ├── Repository.cs
    │       │   ├── IExpenseRepository.cs
    │       │   └── ExpenseRepository.cs
    │       ├── Configurations/
    │       │   ├── ExpenseConfiguration.cs
    │       │   ├── CategoryConfiguration.cs
    │       │   └── BudgetConfiguration.cs
    │       ├── Migrations/
    │       └── PersonalExpenseTracker.Data.csproj
    │
    ├── tests/
    │   ├── PersonalExpenseTracker.UnitTests/
    │   │   ├── Services/
    │   │   ├── Controllers/
    │   │   └── PersonalExpenseTracker.UnitTests.csproj
    │   └── PersonalExpenseTracker.IntegrationTests/
    │       ├── API/
    │       ├── Web/
    │       └── PersonalExpenseTracker.IntegrationTests.csproj
    │
    ├── .github/
    │   └── workflows/
    │       ├── ci.yml
    │       └── cd.yml
    │
    ├── docs/
    │   ├── api/
    │   └── setup/
    │
    ├── PersonalExpenseTracker.sln
    ├── .gitignore
    ├── README.md
    └── docker-compose.yml
```
