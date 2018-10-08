from pyGoogleSearch import *


def allHomesSalesUrl (address):
    raw_web_data = Google("allhomes " + address, pages=1).search()
    output_web_data = DataHandler(raw_web_data).aggregate_data()

    for url in output_web_data:
        if url[0].find("https://www.allhomes.com.au/ah/act/sale-residential/") != -1:
            return url[0];


def allHomesResearchUrl (address):
    raw_web_data = Google("allhomes " + address, pages=1).search()
    output_web_data = DataHandler(raw_web_data).aggregate_data()

    for url in output_web_data:
        if url[0].find("https://www.allhomes.com.au/ah/research/" + address) != -1:
            return url[0];


def page1ResultUrls(address):
    urlLinks = ""
    raw_web_data = Google("allhomes " + address, pages=1).search()
    output_web_data = DataHandler(raw_web_data).aggregate_data()
    for url in output_web_data:
        urlLinks = urlLinks + url[0]
    return urlLinks

