# Research Topics

## C#
- Partial classes
- Properties and auto-properties
- `readonly` fields
- Nullable types (`int?`, `object?`)
- String interpolation (`$"..."`)
- `using` statement (resource disposal)
- `async` / `await`
- Lambda expressions (`=>`)
- Expression-bodied members
- Pattern matching (`is not`, `is`)
- LINQ: `Where`, `Select`, `OrderBy`, `ThenBy`, `ToList`, `OfType`, `Contains`, `FirstOrDefault`
- `HashSet<T>`
- `Convert.ToInt32`
- `string.Join`
- `StringComparison.OrdinalIgnoreCase`

## Windows Forms
- Form lifecycle (`Load` vs `Shown` events)
- Designer partial class pattern
- `SuspendLayout` / `ResumeLayout`
- `Controls.Add` / `Controls.AddRange`
- `DockStyle`
- `AnchorStyles`
- `FormBorderStyle`
- `Show` vs `ShowDialog`
- `MessageBox`
- `Point`, `Size`, `SizeF`
- `Font`, `FontStyle`
- `Color`
- Event handler pattern (`sender`, `EventArgs`)
- `TabIndex`

## DevExpress WinForms
- `XtraForm`
- `SimpleButton`
- `LabelControl`
- `TextEdit`
- `LookUpEdit`
- `PictureEdit`
- `PanelControl`
- `GridControl` + `GridView`
- `ISupportInitialize` (`BeginInit` / `EndInit`)
- `LookAndFeel` (`UseDefaultLookAndFeel`, `Style`)
- `LookAndFeelStyle.Flat`
- `Appearance` (`BackColor`, `BackColor2`, `Options.UseBackColor`)
- `AppearanceDisabled`
- `EditValueChanged` event
- `GetFocusedRowCellValue`

## ADO.NET
- `SqlConnection`
- `SqlCommand`
- `SqlDataAdapter`
- `DataTable`
- `SqlException`
- `Parameters.AddWithValue`
- `ExecuteNonQuery`
- `ExecuteReader` + `SqlDataReader`
- Connection string format

## SQL
- `SELECT` with `JOIN`
- `WHERE` with multiple conditions
- `INSERT INTO`
- `DELETE`
- `IF NOT EXISTS`
- `ORDER BY`
- Parameterized queries (SQL injection prevention)
- Primary key, Foreign key
- Overlap condition logic (`BinisDurakSira < @InisSira AND InisDurakSira > @BinisSira`)

## ASP.NET Core Web API
- Controller class
- `[ApiController]`, `[Route]`, `[HttpGet]` attributes
- `ActionResult<T>`
- `async Task<ActionResult<T>>`
- `Ok()`, `NotFound()`
- DTO pattern (Data Transfer Object)

## Entity Framework Core
- `DbContext` and `DbSet<T>`
- Navigation properties (`virtual ICollection<T>`)
- LINQ to Entities
- `Select` projection
- `FirstOrDefaultAsync`, `ToListAsync`
- Eager loading via navigation properties

## HttpClient
- `HttpClient` with `BaseAddress`
- `GetAsync`, `GetStringAsync`
- `EnsureSuccessStatusCode`
- `ReadAsStringAsync`
- `HttpRequestException`

## System.Text.Json
- `JsonSerializer.Deserialize<T>`
- `JsonSerializerOptions` (`PropertyNameCaseInsensitive`)
- `JsonDocument` / `JsonElement`

## Configuration & Security
- `appsettings.json` structure
- `AppContext.BaseDirectory`
- `File.ReadAllText`
- Keeping secrets out of source control
- `.gitignore`
