# Aplikacja bazodanowa w Blazorze

## Wstęp

Projekt zawiera aplikację webową stworzoną w technologii **Blazor Server (.NET 8.0)**, która umożliwia ocenianie i przeglądanie produktów takich jak filmy, gry czy książki. Dane są przechowywane w relacyjnej bazie danych SQL.

Projekt został przygotowany w ramach kursu **Platformy Programistyczne .NET i Java** na Politechnice Wrocławskiej.

---

## Opis funkcjonalności

Aplikacja umożliwia:

* dodawanie ocen i opisów dla filmów, gier i książek,
* filtrowanie i sortowanie listy ocenianych produktów,
* wyświetlanie średnich ocen oraz listy wszystkich ocen i opisów danego produktu,
* przechowywanie URL do obrazka związanego z produktem,
* wyświetlanie domyślnego obrazka, gdy nie podano żadnego linku,
* możliwość użytkowania tylko po zalogowaniu (autoryzacja przy dodawaniu ocen).

---

## Struktura projektu

* **Data/Product.cs** — Model encji reprezentującej produkt (tytuł, kategoria, rok wydania, lista ocen i opisów, URL do obrazka).
* **Data/ApplicationDbContext.cs** — Klasa kontekstu bazy danych z integracją z Entity Framework.
* **Pages/AddProduct.razor** — Strona formularza do dodawania nowych ocen i opisów dla istniejącego lub nowego produktu.
* **Pages/ProductsList.razor** — Strona z przeglądem wszystkich ocenionych produktów, filtrowaniem i szczegółami.
* **Shared/NavMenu.razor** — Zmieniony pasek nawigacyjny umożliwiający przejście do listy i formularza.
* **Program.cs** — Konfiguracja aplikacji, dodanie usług Blazor, Entity Framework oraz uwierzytelniania.

---

## Użytkowanie w chmurze

Aplikacja została opublikowana w Azure jako:

* **App Service** dla hostingu aplikacji Blazor Server,
* **Azure SQL Database** do przechowywania danych produktów i ocen.

Publikacja została wykonana bezpośrednio z Visual Studio przy użyciu kreatora publikacji.

---

## Technologie

* .NET 8.0
* Blazor Server
* Entity Framework Core
* Microsoft Azure (App Service + SQL Database)
* C#
