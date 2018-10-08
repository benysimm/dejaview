import googlemaps, requests
import scraperutils

#saveImage function, pass three strings, a URL, a fileName, and a description for the logging output.
def saveImage(address,source,url,fileName,fileDescription):
    url = url.replace(' ', '%20')

    scraperutils.downloadImage(address,source,url,fileName)

    #with open(fileName, 'wb') as handle:
    #    response = requests.get(url, stream=True)
    #    if not response.ok:
    #        print (response)

    #    for block in response.iter_content(1024):
    #        if not block:
    #            break

    #        handle.write(block)
    #    print('  ' + fileDescription + ' Downloaded')
    return

def getImagery(address):
    gmaps = googlemaps.Client(key='AIzaSyCPNuuW1GALn89xaVYxuLzuN3JELL0ClLk')
    geocode_result = gmaps.geocode(address) #address.replace('-',' ')

    targetLatLong = str(str(geocode_result[0].get("geometry").get("location").get("lat")) + ',' + str(geocode_result[0].get("geometry").get("location").get("lng")))
    targetAddress = str(geocode_result[0].get("formatted_address"))

    print('Collecting Google Maps imagery...')
    #Get Google Local Road Map
    saveImage(address,'Google',str('https://maps.googleapis.com/maps/api/staticmap?center=' + targetLatLong + '&zoom=18&size=640x640&maptype=roadmap'),'googleLocalRoadMap.jpg','Local Road Map')

    # Get Google Suburb Road Map
    saveImage(address,'Google',str('https://maps.googleapis.com/maps/api/staticmap?center=' + targetLatLong + '&zoom=15&size=640x640&markers=color:red%7C' + targetLatLong + '&maptype=roadmap'),'googleSuburbRoadMap.jpg','Suburb Street Map')

    # Get Google Target Overhead Imagery
    saveImage(address,'Google',str('https://maps.googleapis.com/maps/api/staticmap?center=' + targetLatLong + '&zoom=20&size=640x640&maptype=satellite'),'googleTargetSatellite.jpg','Target Overhead Imagery')

    # Get Google Area Imagery
    saveImage(address,'Google',str('https://maps.googleapis.com/maps/api/staticmap?center=' + targetLatLong + '&zoom=18&size=640x640&markers=color:red%7C' + targetLatLong + '&maptype=hybrid'),'googleAreaImagery.jpg','Area Imagery')

    # Get Google Street View
    saveImage(address,'Google',str('https://maps.googleapis.com/maps/api/streetview?size=680x400&location=' + targetAddress + '&fov=110&pitch=0&key=AIzaSyCPNuuW1GALn89xaVYxuLzuN3JELL0ClLk'),'googleStreetView.jpg','Street View')


    print('Collecting Bing Maps Imagery...')
    #Get Bing Local Road Map
    saveImage(address,'Bing',str('https://dev.virtualearth.net/REST/V1/Imagery/Map/CanvasLight/' + targetLatLong + '/17?mapSize=680,680&pushpin=' + targetLatLong + ';0&key=AluRHNFmdS409Z_IbVrx1_qZEQNEgGJMqce4A1UP1DC0Q0lpQz04g3BcZmCGYkbC'),'bingLocalRoadMap.jpg','Target Street Map')

    #Get Bing Target Overhead Imagery
    saveImage(address,'Bing',str('https://dev.virtualearth.net/REST/V1/Imagery/Map/AerialWithLabels/' + targetLatLong + '/20?mapSize=680,680&key=AluRHNFmdS409Z_IbVrx1_qZEQNEgGJMqce4A1UP1DC0Q0lpQz04g3BcZmCGYkbC'),'bingTargetSatellite.jpg','Target Overhead Imagery')

    #Get Bing Area Imagery
    saveImage(address,'Bing',str('https://dev.virtualearth.net/REST/V1/Imagery/Map/AerialWithLabels/' + targetLatLong + '/18?mapSize=680,680&pushpin=' + targetLatLong + ';89&key=AluRHNFmdS409Z_IbVrx1_qZEQNEgGJMqce4A1UP1DC0Q0lpQz04g3BcZmCGYkbC'),'bingAreaImagery.jpg','Area Imagery')

    return