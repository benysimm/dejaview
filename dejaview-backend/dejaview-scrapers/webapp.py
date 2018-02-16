from bottle import route, run, template, static_file
import scrape
import os


@route('/static/<filename>')
def server_static(filename):
    return static_file(filename, root=os.path.abspath(os.curdir) + os.sep)

@route('/scrape')
def inputAddress():
    picture = "/static/logo.png"
    htmlpage = str('<html><body>'
       + '<script type="text/javascript"> function runScrape() {  '
        + ' addressText = document.getElementById("addressText").value; '
        + ' addressId = addressText.toLowerCase().replace(/ /g,"-").replace(",",""); '
        #+ ' console.log("address id:" + addressId);'
        #+ 'console.log("url" + "http://localhost:8080/scrape/" + addressText); '
        #+ ' window.open("http://localhost:8080/scrape/" + addressText + "/" + addressId, "_self"); '
        #+ ' window.open("http://localhost:3000/address.html?address=" + addressId, "_blank"); '
        + '} </script>'
        + '<style>'
        + '#centerdiv { position:fixed; top: 40%; left: 30%; }'
        + '#textinput { padding-right: 5px;}'
        + '#logo {position:fixed; top: 40%; left: 30%; height: 50px; width: 100px;}'
        #+ ' body { background-image: url(' + picture + '); background-color: #cccccc; background-position:center; background-repeat: no-repeat; x}'
        + '</style>'
        +'<title>Scrape Address</title>'
        + '<div id="logo"><img src=' + picture + ' id="logo"></div>'
        + '<div id="centerdiv"><span id="textinput"><input type="text" name="addressText" id="addressText" size="60"></span>'
        + '<input type="button" value="Scrape Address" onClick="runScrape()"></a> </div>'
        + '</body></html>'
    )
    return htmlpage

#@route('/scrape/<address>/<addressId>')
@route('/scrape/<address>/<addressId>')
def handler(address, addressId):
    data = scrape.scrapetheworld(address, addressId)
    return template('<b>Scraping address : <br> {{address}} <br> {{data}}</b>', address=address, data=data)


run(host='localhost', port=8080)

#http://localhost:8080/test/test