from bs4 import BeautifulSoup
import requests
import re
import scraperutils


def scrapeAddress(addressurl, addressId):
    SOURCE = "AllHomes"
    r = requests.get(addressurl)
    data = r.text
    soup = BeautifulSoup(data, "html.parser")
    #images = ""
    counter = 0
    #title = soup.title.string
    for script in soup.findAll("script"):
        if script.find("srcHighDef") != -1:
            quotes = re.findall('"([^"]*)"', script.text)
            for quotetext in quotes:
                if quotetext.find("_hd.jpg") != -1:
                    #images = images + quotetext
                    counter = counter+1
                    #filename = scraperutils.generateFileName(addressId, SOURCE, quotetext)
                    scraperutils.downloadImage(addressId, SOURCE,  quotetext, scraperutils.urlFileName(quotetext))
                    #remove line below to get all images
                    #break

    return str(counter) + " images returned at: " + addressurl

def scrapeResearch(addressUrl, addressId):
    r = requests.get(addressUrl)
    data = r.text
    soup = BeautifulSoup(data, "html.parser")
    counter = 0
    for image in soup.findAll("img"):
        if image.get('alt') is not None:
            if image.get('alt') == "Block Map":
                counter = counter+1
                filename = scraperutils.generateFileName(addressId, "allhomes_blockmap", counter)
                scraperutils.downloadImage(addressId, "https:" + image.get('src'), filename)

    return "Data scraped from Research"