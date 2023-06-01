# CliLourdConservatoire
Client lourd du Projet Conservatoire

1- Installation de l'environnement de travail
  Installer Visual Studio Community 2022 sur votre pc.
  Installer une plateforme de developpement web locale tel que (WAMP pour Windows).
  
2- Configuration de l'environnement de travail
  Sur votre application Web d'administration pour les systèmes de gestion de base de données MySQL et MariaDB incluse dans le package XAMP (WAMP, LAMP, MAMP),
  souvent étant phpmyadmin, importer la base de donnée consernée par l'application et se trouvant dans le script (dbconservatoire.sql).
  
  L'utilisateur restera 'root' et sans mot de passe pour faciliter votre accès à l'application.
  
  Téléchargez ensuite le dossier zip de l'application sur github et dézippez le.
  Lancez la solution sur Visual Studio.
  Configurez le lancement simultané de l'application et de l'API REST sur Visual Studio: 
    Clique droit sur le nom de la solution > Propriétés > Projets de démarrage multiples > Choisir l'application client lourd et l'API.
  Démarrez le projet.
  
3- Installation et configuration du service windows (ne fonctionne que sur un OS Windows)
  Le service windows responsable de l'envoi de courriels de rappel aux adhérents n'ayant pas payé les frais du trimestre jusqu'à 5 jours avant la date de fin du       trimestre, se trouve dans le dossier WSReminder.
  
  Pour le lancer, démarrez votre terminal en tant qu'administrateur.
  
  Entrez: cd C:\Windows\Microsoft.NET\Framework\v4.0.30319
  Puis entrez: InstallUtil.exe (chemin d'accès au fichier WSReminder.exe sur votre pc)
  
  Vous pouvez maintenant démarrer le service en appuyant sur votre clavier sur (Windows + R).
  Trouvez le service sous le nom de (WSReminder) et appuyez sur "start".
  Le service est désormais lancé.
  
  Remarque: pour le supprimer de votre système, arrêtez le "stop" puis entrez: InstallUtil.exe -u (chemin d'accès au fichier WSReminder.exe sur votre pc)
  dans votre terminal.
