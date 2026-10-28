# Raportul laboratorului nr. 17

**Prelucrarea și validarea datelor din formulare** · proiectul `SportLab`

| | |
|---|---|
| **Numele și prenumele** | *(scrie aici)* |
| **Grupa** | AAW2341 |
| **Data** | 28.10.2026 |
| **Ramura** | `lab-17` |

> **Cum completezi raportul**
>
> 1. La fiecare punct de control din fișă faci o captură de ecran (**Win+Shift+S**, apoi **Salvează** din notificare) și o salvezi în folderul `Raport/capturi/`, cu numele exact din tabel.
> 2. În coloana **Ce s-a întâmplat** scrii pe scurt ce ai văzut: „ca în coloana precedentă” sau ce a fost altfel.
> 3. Nu scrie explicații. Întrebările ți le pune profesorul la susținere.
> 4. Raportul intră în commit-ul `Raport`, înainte de Pull Request.

## Tabelul de testare

| Nr. | Sarcina | Ce faci | Ce trebuie să se întâmple | Ce s-a întâmplat | Captura |
|---|---|---|---|---|---|
| 1 | S1 | Înainte de reparare: în **Abonament nou** lași numele gol și trimiți. | Pagina de eroare: `NullReferenceException`, în `Adauga.cshtml`, la linia cu `foreach`. | | `lab17-1.png` |
| 2 | S1 | După reparare: aceeași trimitere, cu *Lunar* și *Seara* alese. | Formularul revine cu „Scrie numele și prenumele.”. *Lunar* și *Seara* au rămas alese. | | `lab17-2.png` |
| 3 | S2 | Completezi tot, alegi *Lunar*, bifezi antrenorul, **nu** bifezi acordul și trimiți. | Sumarul de sus arată două erori: acordul și antrenorul la abonamentul lunar. Lângă caseta acordului apare mesajul ei. | | `lab17-3.png` |
| 4 | S3 | Trimiți fără nicio activitate, apoi cu *Yoga* și *Box* alese. | Întâi: „Alege cel puțin o activitate.”. Apoi lista arată pe rândul nou „Yoga, Box”. | | `lab17-4.png` |
| 5 | S4 | În **Cont de membru** scrii două parole diferite și trimiți. | Sub „Confirmă parola” apare „Parolele nu coincid.”. Ambele câmpuri ale parolei sunt goale. | | `lab17-5.png` |
| 6 | S4 | Scrii aceeași parolă de două ori, de cel puțin 8 caractere. | Pagina „Contul a fost creat”, cu numărul de caractere ale parolei. | | `lab17-6.png` |

## Capturile

### 1. Pagina de eroare, înainte de reparare (Sarcina 1)

![Captura 1](capturi/lab17-1.png)

### 2. Formularul revenit corect (Sarcina 1)

![Captura 2](capturi/lab17-2.png)

### 3. Sumarul validării cu regulile din acțiune (Sarcina 2)

![Captura 3](capturi/lab17-3.png)

### 4. Lista cu activitățile alese (Sarcina 3)

![Captura 4](capturi/lab17-4.png)

### 5. Parolele care nu coincid (Sarcina 4)

![Captura 5](capturi/lab17-5.png)

### 6. Contul creat (Sarcina 4)

![Captura 6](capturi/lab17-6.png)

## Commit-urile

Verifică în **Git → View Branch History** că pe ramura `lab-17` există, în ordine:

- [ ] `S1: listele la reafișarea formularului`
- [ ] `S2: regulile din acțiune și sumarul validării`
- [ ] `S3: lista activităților`
- [ ] `S4: confirmarea parolei cu Compare`
- [ ] `Raport`
