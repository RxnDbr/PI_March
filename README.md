# PI_Mars
Windows Form / C# project to plan astronauts'activity

Dans une salle de contrôle de mission dédiée au domaine spatial, illustrée figure 1, on réunit de nombreux experts de différentes spécialités. Ils suivent en temps réel la mission, sont attentifs à la moindre difficulté et apportent leurs 

conseils sur les décisions à prendre. Il y a par exemple des experts qui sont en charge du bon déroulement de la 

mission du point de vue technique (position, orientation, état des batteries, etc.), d’autres de la communication avec 

l’engin spatial, d’autres encore qui planifient les activités heure par heure pour les prochaines 48 heures, ainsi que 

des scientifiques qui analysent les données reçues. S’il s’agit d’une mission habitée, il y a en plus une équipe chargée 

de surveiller les astronautes, que ce soit du point de vue physiologique, psychologique ou relationnel.

Plaçons-nous dans le contexte d’une mission habitée martienne. On s’intéresse dans ce projet à un outil de 

planification qui serait utile à l’équipe en charge de planifier les activités des astronautes. Notez que cet outil 

pourrait être exploité ultérieurement lors d’une simulation organisationnelle effectuée dans une salle de simulation 

de l’ENSC. Les spécifications sont les suivantes :

Gestion des activités

Les activités sont classées en 6 catégories et plusieurs sous-catégories, selon la hiérarchie indiquée figure 2. 

L’application est consacrée à la gestion des activités. Pour cela, on gère un planning sur 500 jours, qui correspond à 

la durée de la mission en surface. Il faut 3 niveaux de visualisation sur 3 fiches différentes.


Au niveau 3, il y a un descriptif de l’activité. Il faut pouvoir choisir dans la liste présentée figure 2. A cela, on doit 

ajouter les informations suivantes (à remplir par l’utilisateur si non disponibles) : numéro du jour, heure de 

début (précision de 10’), heure de fin (précision de 10’), la liste des astronautes concernés 

(on indiquera les noms possibles), le lieu, ainsi qu’un texte descriptif limité à 400 caractères.

En ce qui concerne le lieu, on dispose d’une carte de la zone. Pour l’exemple fourni, il s’agit 

d’une image de taille 1095 par 2053 pixels représentant la région de Nanedi Vallis. L’habitat 

est situé à l’origine du repère (0,0) et correspond en pixels à la position (700, 1000) de 

l’image. Un lieu est défini par un nom et une position (x,y) exprimées en mètres 

relativement à l’habitat selon l’axe ouest-est (abscisses) et sud-nord (ordonnées). La 

résolution de l’image est de 5 mètres par pixel en première approximation selon les 2 axes. 

Si l’activité est en extérieur, l’utilisateur doit pouvoir entrer les coordonnées directement ou 

sélectionner sur la carte une position par simple clic. L’utilisateur doit pouvoir enregistrer la 

nouvelle activité dans le fichier des activités (voir plus loin) ou annuler, ce qui ramène à la 

fiche de niveau 2. 

Analyse de l’activité : Depuis la fiche présentant le calendrier, il doit être possible d’analyser les 

activités passées. Pour cela, l’utilisateur doit pouvoir effectuer une recherche des jours

concernés par une activité donnée. Par exemple, en entrant l’activité « Medical act », le 

programme doit renvoyer la liste des jours où un acte médical a été effectué. Il peut s’agir Figure 3 : Image de

également d’une activité générique, par exemple « Repair ». Il doit également être possible d’effectuer une 

recherche en fonction d’un mot présent dans le texte descriptif de l’activité ou du compte-rendu. Ensuite, l’activité 

doit pouvoir être sélectionnée pour visualiser les informations détaillées. Enfin, l’utilisateur doit pouvoir sélectionner 

une période pour affiner sa recherche.

En ce qui concerne l’activité d’exploration, l’analyse se fait avec la carte, éventuellement en utilisant une autre fiche 

(à vous de proposer la solution la plus ergonomique). L’utilisateur doit pouvoir visualiser tous les lieux où sont allés 

les astronautes, ainsi que les lieux qui sont programmés pour les jours suivants. Cela concerne l’exploration en 

scaphandre, avec un véhicule, ou une expérience en extérieur. On affichera sur la carte des icônes de différentes 

formes ou/et couleur pour représenter ces activités, en effectuant une distinction importante entre le passé et le 

futur. Ces icônes seront « cliquables », c’est-à-dire que sur le clic, on doit afficher les informations de l’activité, 

notamment la date et la description détaillée. Vous devez également proposer à l’utilisateur de sélectionner une 

période définie par une date de début et une date de fin (numéros de jour), afin que ne soient affichées que les 

activités en extérieur qui se sont déroulées pendant ladite période.

Fichiers : Des informations importantes seront stockées dans 2 fichiers XML distincts. 

Le premier fichier concerne les informations générales, notamment le nom du fichier image servant de carte pour 

l’exploration, la position de l’habitat, ainsi que le nombre et le nom de chaque astronaute. Ce fichier inclut 

également la hiérarchie des activités présentée figure 2, qui pourrait éventuellement être modifiée ultérieurement, 

ainsi que la description des activités de la journée par défaut. A vous de définir la structure de ce fichier XML.

Le 2ème fichier XML concerne le détail des activités planifiées, passées et futures. Au lancement de l’application, ce 

fichier sera lu de manière automatique. La création, la modification ou la suppression se fait à partir de la fiche de 

niveau 3. Le nom de ce fichier n’est pas connu de l’utilisateur.

