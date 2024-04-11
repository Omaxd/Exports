Solucja jest złożona z następujących projektów:
--REPO
CommonRepository - interfejsy dla repozytorów,
MockData - repozytorium do testów. Korzysta z losowo wygenerowanych danych. Dane przechowuje w listach,
MsSqlDatabase - repozytorium połączone z MS SQL. Korzysta ADO.NET.

Model - definicja klas User, Place oraz Export, które są wykorzystywane w solucji.
ViewLogic - definicja serwisu, który pobiera dane z repozytorium i odpowiednio przygotowuje dla widoku.

DesktopView - WinFormsowy widok korzystający z DevExpress. W pełni responsywny.
W tym miejscu znajduje się również definicja kontenera IoC oraz wstrzykiwanie zależności.

By włączyć aplikację w trybie testu w Program.cs w projekcie DesktopView należy zmienić drugi parametr na false w 23 linijce.
By włączyć aplikację w trybie bazodanowym:
-trzeba stworzyć 3 tabele oraz zapełnić je. Można do tego użyć skryptu CreateAndFillTables.sql z tego repozytorium. Skrypt jest jednorazowego użycia (nie ma opcji drop),
-zaktualizować plik konfiguracyjny App.config w projekcie DesktopView. Należy odpowiednio zmodyfikować connectionString dla wartości "local".
