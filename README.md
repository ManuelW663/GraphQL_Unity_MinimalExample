# GraphQL_Unity_MinimalExample

Dieses quasi leere Beispielprojekt soll lediglich zeigen, dass es möglich ist der "Graph QL Config" Instanz per Code Referenzen zu Graph QL Queries hinzuzufügen.

Zu Beginn kann man im Inspektor prüfen, dass die "Graph QL Config" Komponente des "ScriptObject" über keine referenzierten Queries verfügt.
Bei "Play" wird nun das Skript "AddGraphQL_Queries" (Ordner "Scripts") ausgeführt, und alle Dateien des Ordners "GraphQL_Assets/Resources/GraphQL_Files" werden der GraphQLConfig hinzugefügt.
