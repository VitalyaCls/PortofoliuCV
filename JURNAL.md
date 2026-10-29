# Jurnal de lucru — Nume Prenume, varianta nr. __

## Sesiuni de lucru
| Data | Ore | Etapa | Ce am realizat | Dificultăți și rezolvare | Surse/IA |
|------|-----|-------|----------------|--------------------------|----------|
| 15.10.2026 | 2h | S0 | Configurarea inițială a proiectului C# WPF, structura soluției și crearea repository-ului pe GitHub. | Întâmpinarea primilor pași în structurarea proiectului. Rezolvat prin configurarea corectă a `.gitignore`. | Documentație WPF |
| 16.10.2026 | 2h | S1 | Crearea interfeței principale (`MainWindow.xaml`), adăugarea meniului și a structurii de bază. | Potrivirea dimensiunilor ferestrei. Rezolvat prin definirea de `Grid.RowDefinitions`. | Ghiduri XAML |
| 16.10.2026 | 3h | S2 | Implementarea controalelor de introducere și validare a datelor (TextBox, ComboBox, DatePicker). | Validarea câmpurilor goale. Rezolvat prin verificarea proprietăților la salvare. | Asistent IA |
| 17.10.2026 | 2h | S3 | Crearea claselor de comenzi (`CommandBindings`) și gestionarea listei de programări existente. | Legarea corectă a comenzilor rapide. Rezolvat prin adăugarea namespace-urilor necesare. | Asistent IA |
| 17.10.2026 | 3h | S4 | Implementare logo vectorial animat (Canvas, Viewbox, Path, RotateTransform, Storyboard) și rezolvare conflicte GitHub. | Conflicte de merge pe `MainWindow.xaml`. Rezolvat prin sincronizare locală și rezolvare manuală a diferențelor. | Asistent IA |
| 18.10.2026 | 2h | S5 | Crearea dicționarului de resurse `Themes/Styles.xaml`, definirea stilurilor globale, culorilor și triggerelor vizuale (Hover, IsFocused). | Aplicarea stilurilor peste controale standard. Rezolvat prin definirea temei centrale în `App.xaml`. | Asistent IA |
| 18.10.2026 | 3h | S6 | Arhitectura MVVM: crearea claselor `ViewModelBase`, `RelayCommand`, `ProgramareModel`, `MainViewModel` și organizarea în folderul `Views`. | Mutarea ferestrelor și actualizarea namespace-urilor. Rezolvat prin ajustarea claselor și a referințelor din code-behind. | Asistent IA |
| 20.10.2026 | 3h | S7 | Integrarea bazei de date SQLite (`DatabaseHelper.cs`), persistența datelor și operațiuni CRUD (Adăugare, Editare, Ștergere). | Legarea comenzilor de ștergere și editare la obiectul selectat. Rezolvat prin adăugarea proprietății `SelectedProgramare` în `MainViewModel`. | Asistent IA |
| 20.10.2026 | 2h | S8 | Implementarea funcției de export în format CSV, testarea finală a aplicației, verificarea structurii GitHub și redactarea raportului. | Vizibilitatea textului pe butoane în funcție de starea lor. Rezolvat prin setarea corectă a proprietăților `Foreground` în XAML. | Asistent IA |


## Reflecția etapei S1-S6
- **Realizat:** Structură completă a interfeței cu teme vizuale moderne și arhitectură MVVM decuplată prin Data Binding.
- **Cea mai grea problemă:** Organizarea arhitecturii MVVM și refactorizarea legăturilor din XAML fără a strica funcționalitățile existente.
- **Ce am înțeles nou:** Cum funcționează notificarea schimbării proprietăților prin `INotifyPropertyChanged` și manipularea listelor dinamice cu `ObservableCollection`.
- **Ce aș face diferit:** Aș structura folderele `Models`, `ViewModels` și `Views` încă din prima zi a proiectului.

## Reflecția etapei S7
- **Realizat:** Conectarea bazei de date locale SQLite (`salon_database.db`), crearea automată a tabelelor și implementarea operațiunilor complete de Adăugare, Editare și Ștergere sincronizate în timp real cu interfața WPF.
- **Cea mai grea problemă:** Sincronizarea modificărilor efectuate în baza de date cu colecția din interfață (`ObservableCollection`).
- **Ce am înțeles nou:** Cum se folosește un `SQLiteConnection` eficient în C# și cum se menține arhitectura MVVM curată eliminând tot codul din `MainWindow.xaml.cs`.
- **Ce aș face diferit:** Aș folosi un ORM (de exemplu Entity Framework Core) pentru a automatiza maparea obiectelor, deși SQLite brut prin ADO.NET oferă un control excelent.

## Reflecția etapei S1-S8 (Finală)
- **Realizat:** O aplicație WPF complet funcțională pentru gestionarea salonului de frumusețe, construită modular conform arhitecturii MVVM, cu tematică vizuală personalizată, persistență în baza de date SQLite și funcționalitate de export CSV.
- **Cea mai grea problemă:** Trecerea de la codul tradițional scris în code-behind (`xaml.cs`) la separarea strictă a logicii în `ViewModels` prin `Data Binding` și `RelayCommand`.
- **Ce am înțeles nou:** Gestionarea întregului ciclu de viață al unui proiect software: de la schelet XAML, animații, stiluri globale, până la arhitectură MVVM, persistență SQLite și versionare avansată pe GitHub (ramuri, PR-uri, rezolvare conflicte).
- **Ce aș face diferit:** Aș defini de la bun început arhitectura MVVM și schema bazei de date pentru a evita refactorizările pe parcursul etapelor.

## Declarație privind utilizarea IA
| Data | Instrument | Pentru ce | Ce am modificat eu |
|------|------------|-----------|--------------------|
| 17.10.2026 | Asistent IA (Gemini) | Generare structură forme vectoriale XAML, definire Storyboard și asistență la rezolvare conflicte Git. | Am adaptat codul la tema aplicației de salon, am ajustat viteza animațiilor și am efectuat manual commit-urile și merge-ul. |
| 18.10.2026 | Asistent IA (Gemini) | Asistență la crearea claselor de bază MVVM (`ViewModelBase`, `RelayCommand`) și organizarea namespace-urilor pentru `Views`. | Am scris codul de legătură (Data Binding) în XAML, am ajustat proprietățile modelelor și am testat funcționalitatea aplicației. |
| 20.10.2026 | Asistent IA (Gemini) | Asistență la scrierea clasei `DatabaseHelper` (SQLite) și refactorizarea `MainViewModel` pentru comenzile CRUD și exportul CSV. | Am configurat legăturile XAML pentru noile butoane, am testat persistența pe disc și am configurat salvarea fișierului CSV. |

## Fișa de autoevaluare
| Etapa | Tag creat la | Nr. commit-uri / zile | Nivel atins | Autoevaluare (1–5) | De exersat |
|-------|--------------|-----------------------|-------------|--------------------|------------|
| S0 | 15.10.2026 | 2 commit-uri / 1 zi | Finalizat | 5 | Structurarea proiectelor WPF |
| S1 | 16.10.2026 | 3 commit-uri / 1 zi | Finalizat | 5 | Meniuri și structuri XAML |
| S2 | 16.10.2026 | 3 commit-uri / 1 zi | Finalizat | 5 | Validarea datelor de intrare |
| S3 | 17.10.2026 | 4 commit-uri / 1 zi | Finalizat | 5 | Crearea și legarea comenzilor WPF |
| S4 | 17.10.2026 | 5 commit-uri / 1 zi | Finalizat | 5 | Animații XAML și rezolvare conflicte Git |
| S5 | 18.10.2026 | 3 commit-uri / 1 zi | Finalizat | 5 | Stiluri, resurse globale și Triggere |
| S6 | 18.10.2026 | 4 commit-uri / 1 zi | Finalizat | 5 | Arhitectura MVVM și Data Binding |
| S7 | 20.10.2026 | 3 commit-uri / 1 zi | Finalizat | 5 | Persistența datelor și SQLite în C# |
| S8 | 20.10.2026 | 2 commit-uri / 1 zi | Finalizat | 5 | Exportul datelor și documentația proiectului |