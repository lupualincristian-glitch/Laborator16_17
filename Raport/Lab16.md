# Raportul laboratorului nr. 16

**Formulare HTML cu helpere HTML și tag helpere** · proiectul `AdmitereLab`

| | |
|---|---|
| **Numele și prenumele** | Lupu Alin-Cristian |
| **Grupa** | AAW2341 |
| **Data** | 28.10.2026 |
| **Ramura** | `lab-16` |

> **Cum completezi raportul**
>
> 1. La fiecare punct de control din fișă faci o captură de ecran (**Win+Shift+S**, apoi **Salvează** din notificare) și o salvezi în folderul `Raport/capturi/`, cu numele exact din tabel.
> 2. În coloana **Ce s-a întâmplat** scrii pe scurt ce ai văzut: „ca în coloana precedentă” sau ce a fost altfel.
> 3. Nu scrie explicații. Întrebările ți le pune profesorul la susținere.
> 4. Raportul intră în commit-ul `Raport`, înainte de Pull Request.

## Tabelul de testare

| Nr. | Sarcina | Ce faci | Ce trebuie să se întâmple | Ce s-a întâmplat | Captura |
|---|---|---|---|---|---|
| 1 | S1 | Deschizi **Cerere nouă**, apoi sursa paginii (**Ctrl+U**) și cauți `AnulAbsolvirii`. | Formularul are câmpurile E-mail, Telefonul, Anul absolvirii, Motivația, cu etichete. În sursă, câmpul anului are `name="AnulAbsolvirii"` și `value="2026"`. | | `lab16-1.png` |
| 2 | S2 | Deschizi lista **Specialitatea** și o închizi. Apoi, în sursa paginii (**Ctrl+U**), cauți `<select`. | Lista începe cu „— alege specialitatea —” și are cinci specialități. În sursă: `<select id="Specialitate" name="Specialitate">` și șase etichete `<option>`. | | `lab16-2.png` |
| 3 | S3 | Completezi tot, în afară de specialitate. Alegi *Frecvență redusă*, bifezi căminul și trimiți. | Formularul revine cu „Alege specialitatea.”. *Frecvență redusă* și căminul au rămas alese. | | `lab16-3.png` |
| 4 | S3 | Completezi cererea corect și o trimiți. | Se deschide lista. Cererea ta este ultima, cu data de azi și forma aleasă. | | `lab16-4.png` |
| 5 | S4 | Deschizi lista cererilor. | În coloana E-mail adresele sunt linkuri. | | `lab16-5.png` |
| 6 | S4 | În sursa listei cauți `mailto:`. | Fiecare adresă este `<a class="link-secondary" href="mailto:…" title="Scrie un e-mail">`. | | `lab16-6.png` |

## Capturile

### 1. Câmpurile text și sursa paginii (Sarcina 1)

![Captura 1](capturi/lab16-1.png)

### 2. Sursa paginii cu lista derulantă (Sarcina 2)

![Captura 2](capturi/lab16-2.png)

### 3. Formularul revenit cu eroarea (Sarcina 3)

![Captura 3](capturi/lab16-3.png)

### 4. Lista cu cererea nouă (Sarcina 3)

![Captura 4](capturi/lab16-4.png)

### 5. Lista cu linkurile e-mail (Sarcina 4)

![Captura 5](capturi/lab16-5.png)

### 6. Sursa paginii cu linkul generat de TagBuilder (Sarcina 4)

![Captura 6](capturi/lab16-6.png)

## Commit-urile

Verifică în **Git → View Branch History** că pe ramura `lab-16` există, în ordine:

- [ ] `S1: câmpurile text cu helpere HTML`
- [ ] `S2: lista derulantă a specialităților`
- [ ] `S3: butoanele radio și caseta căminului`
- [ ] `S4: helperul LinkEmail cu TagBuilder`
- [ ] `Raport`
