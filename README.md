# Exercice initiation Visual Studio : Section 2
Clonez ce projet sur votre ordinateur. Au besoin, suivez les instructions de la section précédente.

Ensuite, ouvrez le nouveau projet dans visual studio 2022 en double cliquant sur le fichier de solution Atelier15.sln du nouveau dépot git. 

Vous pouvez comparer votre code de la section 1 à celui fourni. Voyez vous des différences?

## Partie 1 : Afficher les initiales

À la place d’afficher le nom complet de l’utilisateur, faites afficher uniquement ses initiales. Donc, à la place d’afficher ```Hello Joe DOE```, faite afficher ```Hello JD```.

<details>
<summary>Indice</summary>
Pour accéder au à un caractère spécifique d’une chaine de caractères, voici la syntaxe : maChaine[index] (remplacer maChaine par votre nom de variable et index par 0, 1, 2 ... selon la position du caractère voulu)
</details>

Ensuite, créez un nouveau commit et pusher vous modification de nouveau.

## Partie 2 : Afficher la longeur du nom complet
Il faut maitenant afficher à la suite du message final la longeur du prénom additionée au nom complet. 

Par exemple, si on entre comme prénom ```Joe``` et comme nom ```Doe```, la sortie sera donc ```Hello JD 6``` .

**Faites attention de mettre un espace entre les initiales et la longeur des noms.**

<details>
<summary>Indice</summary>
On utilise des variables de type ```string monNomDeString``` dans le code pour stocker les chaines de caractères. Pour stocker des nombres entiers, il faut utiliser ```int monNomDeInt```.
</details>

<details>
<summary>Indice 2</summary>
Utilisez votre moteur de recherche favori pour trouver comment déterminer la longeur d'un string :)

Exemple de recherche : c# string length

Rechercher en anglais donne de bien meilleurs résultats.
</details>