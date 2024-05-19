/*
 * Client-Programm, um Socket-Verbindung aufzubauen
 */

#include <stdio.h>
#include <stdlib.h>
#include <errno.h>
#include <string.h>
#include <netdb.h>
#include <sys/types.h>
#include <netinet/in.h>
#include <sys/socket.h>
#include <unistd.h>

/* Zielport */
#define PORTNR 3000

/* Ziel-Host, in unserem Fall 127.0.0.1 */
#define HOSTNAME "localhost"

/* Nachricht, die versendet werden soll */
#define NACHRICHT "BSN2\n"

int main(int argc, char *argv[])
{

    /* Datei-Deskriptor für das Socket */
    int sockfd;

    /* Struct, um einen Internet-Host zu beschreiben */
    struct hostent *host_endpunkt;

    /* Struct für Ziel-Adresse */
    struct sockaddr_in zieladresse;

    /* Wir lassen unsere struct durch gethostbyname befüllen und übergeben dafür den Ziel-Hostnamen */
    if ((host_endpunkt = gethostbyname(HOSTNAME)) == NULL)
    {
        perror("Fehler beim Aufruf von gethostbyname");
        exit(EXIT_FAILURE);
    }

    /* Socket erstellen:
       AF_INET: IPv4
       SOCK_STREAM: Zuverlässig Zwei-Wege-Verbindung, d.h. TCP
       0: Protokollfamilie, 0 führt dazu, dass für SOCK_STREAM, TCP genommen wird */
    if ((sockfd = socket(AF_INET, SOCK_STREAM, 0)) == -1)
    {
        perror("Fehler beim Erstellen des Socket");
        exit(EXIT_FAILURE);
    }

    /* Padding mit Nullen nötig wegen Unterschieden in den Datenstrukturen sockaddr und sockaddr_in */
    memset(&zieladresse, 0, sizeof(zieladresse));

    /* Ziel-Adresse ist eine IPv4-Adresse */
    zieladresse.sin_family = AF_INET;

    /* host-to-network short: übersetzt eine unsigned short int in network byte order.
     Im Rahmen von Netzwerkprotokollen wird network byte order verwendet. Host-Systeme verwenden host byte order. */
    zieladresse.sin_port = htons(PORTNR);

    /* Internet-Adresse */
    zieladresse.sin_addr = *((struct in_addr *)host_endpunkt->h_addr);

    /* Socket-Verbindung aufbauen */
    if (connect(sockfd, (struct sockaddr *)&zieladresse, sizeof(struct sockaddr)) == -1)
    {
        perror("Fehler beim Aufruf von connect");
        exit(EXIT_FAILURE);
    }

    /* Da die Verbindung jetzt steht, Nachricht senden*/
    if (send(sockfd, NACHRICHT, strlen(NACHRICHT), 0) == -1)
    {
        perror("Fehler beim Senden der Nachricht");
        exit(EXIT_FAILURE);
    }

    /* Socket schließen */
    close(sockfd);

    return EXIT_SUCCESS;
}
