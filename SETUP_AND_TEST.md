# AcademicGear — corrected local/offline POS project

## Status

This is a source-code repair and static-checked package. It was **not compiled with Windows/.NET Framework** or executed against Microsoft SQL Server in the preparation environment. Run the steps below on Windows before submitting or pushing to a shared branch.

## What was changed

- No Azure SQL runtime connection. UI/App.config points to `(localdb)\MSSQLLocalDB` and `AcademicGearDB`.
- `BusinessLogic/LocalDatabase.cs`: creates the DB and six tables on startup, upgrades missing unit/snapshot columns, inserts missing demo accounts and categories, and keeps existing records.
- `BusinessLogic/Repository/UserRepo.cs`: reads the local database via configuration (unchanged login contract).
- `BusinessLogic/Repository/ProductRepo.cs`: categories, product registration, search, edit and delete.
- `BusinessLogic/Repository/SalesRepo.cs`: transactional checkout and stock deduction, sales retrieval and receipt data.
- `UI/ProductRegistrations.cs`: Save and Update now work with the database.
- `UI/InventoryManagement.cs`: table loading, search, category filter, View/Edit/Delete.
- `UI/PointOfSale.cs`: search, cart, quantity, discount, Cash/Card/GCash demo payments, sale/stock transaction, receipt.
- `UI/Receipt.cs`: loads real completed sales and opens Print Preview.
- `UI/SalesHistory.cs`: basic sales history table and selected receipts.
- DB SQL project schema aligned with SQL Server 2016-compatible (not Azure); removed old Users table definition. Disabled auto-deploy in solution. Do not Publish the DB project onto a populated DB without a separate migration review.
- Existing form Designer.cs/.resx visual layouts preserved. BusinessLogic and UI .csproj files include the added classes.

## Required Windows setup

1. Install **Visual Studio 2022** with **.NET desktop development**, **.NET Framework 4.7.2 targeting pack**, and **SQL Server Express LocalDB**. For the DB .sqlproj to build in Visual Studio, also install SSDT / SQL database project support (Data storage and processing).
2. Extract the ZIP, open `Academic_Gear.sln` in Visual Studio.
3. Set **UI** as Startup Project.
4. Check `UI/App.config`. It should use `Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AcademicGearDB;Integrated Security=True;Connect Timeout=60;`.
5. If LocalDB exists but is stopped, run in Command Prompt: `sqllocaldb start MSSQLLocalDB`.
6. Build -> Rebuild Solution. If DB.sqlproj fails because SSDT is missing, install the SQL Server Data Tools component; the WinForms UI does **not** use the SQL database project at runtime.
7. Run with F5. First startup should create AcademicGearDB and seed test accounts locally; subsequent starts preserve records.

## Default demo logins

- Admin: `admin` / `admin123` -> Dashboard -> Inventory -> Add New Product
- Cashier: `cashier` / `cashier123` -> CashierDashboard -> POS

**Security note:** Passwords are plaintext because these are the requested classroom demonstration credentials. Do not use this approach for real systems, internet-facing software, or real customer data. Replace it with salted password hashes and controlled account creation before production.

## Acceptance test: local, end-to-end

1. Open SSMS and connect to `(localdb)\MSSQLLocalDB` with Windows Authentication; confirm `AcademicGearDB` exists. If you previously used a different SQL Server instance, your old data stays there and is *not* copied automatically.
2. Log in as Admin. Inventory should show an empty list (on new installation). Click **+ Add New Product**.
3. Add product code `P001`, name `Notebook`, category `School Supplies`, price `50.00`, quantity `10`, unit `Piece`. Click Save. Inventory should now display Notebook.
4. Search `Notebook`; confirm it is listed. View it; edit price or stock; save. Restart app and ensure changes persisted.
5. Log out. Log in as Cashier. Open POS. Search `Notebook`, select row, set quantity to `2`, click Add Product. Check subtotal = `100.00` (if unit price still 50).
6. Enter discount `10`, select **Cash**, click Process Payment; enter cash received `100`. Expected total `90`, change `10`.
7. Receipt dialog should show Notebook (2), discount 10, received 100, change 10. Click **Print** for Print Preview; select printer from the preview UI if you want a physical receipt.
8. Return to POS; check stock decreased from 10 to 8. Go back to CashierDashboard, open Sales History, and view the receipt again.
9. Re-launch application and confirm sale history remains present, stock remains 8, and login still works.
10. For a clean teammate test, clone the repository on a second Windows machine with LocalDB installed. Run the program. It should create a **separate** AcademicGearDB on that user account, even though their Windows username differs.

## Troubleshooting

- `Cannot open database AcademicGearDB`: ensure the same LocalDB instance is installed and used; SSMS must show the `(localdb)\MSSQLLocalDB` instance, not a different `SQLEXPRESS` instance. Check DB permissions only if the server/database is correct.
- `LocalDB not installed`: install SQL Server Express LocalDB, then run `sqllocaldb info`.
- `LocalDatabase does not exist in namespace`: confirm BusinessLogic.csproj compiles LocalDatabase.cs and UI references BusinessLogic; rebuild.
- SQL Project not supported: install SSDT, or unload DB.sqlproj temporarily; it is not part of the running app's connection.
- `Existing AcademicGearDB has incompatible table layout`: back up the database, inspect the old schema and migrate it; don't drop the DB while it contains important records.
- If errors occur after opening Product Registration or POS, send the exact Visual Studio exception/stack trace for targeted correction.

## Important scope notes

- **Offline/local-only** means every PC has its own inventory and sales; GitHub syncs source, not each user's SQL Server records.
- Card and GCash selections **record a demo payment type only**. They do not charge a card or call a GCash service.
- The Receipt print button uses Windows Print Preview and requires a configured printer to physically print.
- Inventory product delete is blocked when an existing completed sale references that product; set stock to zero instead.
- Legacy non-POS dashboard placeholders (Manage Account, etc.) were not in the original working feature scope and have not been implemented.
- This script does not copy data from your old Azure server or from a separate local SQL Server instance.
- SQL database project (DB.sqlproj) is an *optional design-time schema project*; live app initialization is controlled by BusinessLogic/LocalDatabase.cs.

## Push to GitHub

1. First verify the complete flow locally. Make a backup of your existing work.
2. Copy these repaired project files into your Git repository **without replacing its .git folder**.
3. Inspect changes in Git Changes. Commit the source files, Designer files, .csproj, .sqlproj, .sln, App.config, this document, and .gitignore.
4. Do not commit `.mdf`, `.ldf`, `.vs`, `bin`, `obj`, passwords beyond demo fixtures, secrets or private connection strings.
5. Push and test with a clean clone by a teammate.
