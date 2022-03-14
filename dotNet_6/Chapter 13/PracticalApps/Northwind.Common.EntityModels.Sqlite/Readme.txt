Prerequiresite:

install dotnet-sdk-2.2.207-win-x64

Init database (sqlite):
1. Copy Northwind4SQLite.sql into teh project folder.
2. cmd: c:\sqlite\sqlite3 northwind.db -init data/Northwind4SQLite.sql

Generate context:

1. Install Microsoft.EntityFrameworkCore.Sqlite;
2. Install Microsoft.EntityFrameworkCore.Design
3. Generate DbContext from the Sqlite database file:
	dotnet ef dbcontext scaffold "Filename=northwind.db" Microsoft.EntityFrameworkCore.Sqlite --namespace Packt.Shared --data-annotations -o Models --schema --context-dir Data
	dotnet ef dbcontext scaffold "Filename=data/northwind.db" Microsoft.EntityFrameworkCore.Sqlite --namespace Packt.Shared --data-annotations -o Models --context-dir DbSchema
working:
	dotnet ef dbcontext scaffold "Filename=data/northwind.db" Microsoft.EntityFrameworkCore.Sqlite --namespace Packt.Shared --data-annotations -o Models --context-dir DataContext

Not workig for Sqlite:
		"--schema" for all tables
4. Add [Key] attribute manually if not present
5. Add [Required] for Models where needed. 
6. Add validation if needed like [RegularExpression("[A-Z]{5}")]. For example, upper case chars only.
7. Use VS replace All for Sqlite:

\[Column\(TypeName = "(nchar|nvarchar) \((.*)\)"\)\]
to 
$&\n    [StringLength($2)]

DteTime as byte[] --> DateTime?

money as byte[] --> decimal?
"bit" as byte[] --> bool

see p558 for more manual data types fixes (long --> int etc.).
#####################################################################
1. create new typelib Northwind.Common.DataContext.Sqlite and move northwindContext to it.
2. remove all entity.Property(e => e.SupplierId).ValueGeneratedNever(); Otherwise, the Insters will be returning 0.
3. Add      modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.UnitPrice)
                .HasConversion<double>();
            });

4. Add class NorthwindContextExtensions.cs for DI
see MsSql specifics on p.562