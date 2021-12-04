using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleGraphQL;


public class AddGraphQL_Queries : MonoBehaviour
{
    public GraphQLConfig config;

    public Object[] files;

    void Start()
    {
        // Laden aller Files im Verzeichnis "GraphQL_Files" in Ordnern namens "Resources",
        // hier unter "GraphQL_Assets"
        files = Resources.LoadAll("GraphQL_Files");

        Debug.Log("Files im Resources Ordner: " + files.GetLength(0));

        // Hinzufügen der aufgefundenen Files zu config, notwendig ist ein Cast der Objekte,
        // welcher bei unpassenden Files im Resources-Ordner zu Fehlern führen wird
        config.Files.Add((GraphQLFile)files[0]);
        config.Files.Add((GraphQLFile)files[1]);
    }
}
