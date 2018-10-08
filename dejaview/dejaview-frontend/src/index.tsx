import React from 'react';
import ReactDOM from 'react-dom';



let x = 0;
const PI = 3.141593;

let nums: number[] = [2, 3, 5, 7, 8, 9, 10, 11, 12];
let fives: number[] = [];


nums.forEach((v, i) => {
    if (v % 5 === 0) {
        fives.push(v);
        console.log("ping ping ${v}");
    }
});



class Shape {
    foo: string;

    constructor(id: string, x: number, y: number) {
        console.log('superman');
        let b = id + y + x;
        this.foo = "";
    }
};




function getParameterByName(name: string) {
    var url = window.location.href;
    name = name.replace(/[\[\]]/g, "\\$&");
    var regex = new RegExp("[?&]" + name + "(=([^&#]*)|&|#|$)"),
        results = regex.exec(url);
    if (!results) return null;
    if (!results[2]) return '';
    return decodeURIComponent(results[2].replace(/\+/g, " "));
}


function toTitleCase(str: string)
{
    return str.replace(/\w\S*/g, function(txt){return txt.charAt(0).toUpperCase() + txt.substr(1).toLowerCase();});
}



class Heading extends React.Component<any, any> {

    public render() {

        var addressParam = getParameterByName('address');

        if (addressParam != null) {
            addressParam = addressParam.replace(/-/g, " ");
            addressParam = toTitleCase(addressParam);
        }

        return (
            <section className="hero is-dark">
                <div className="hero-body">
                <div className="container">
                    <h1 className="title">
                    {addressParam}
                    </h1>
                    <h2 className="subtitle">
                    Residential property
                    </h2>
                </div>
                </div>
            </section>
        )
    }
}

ReactDOM.render(
    <Heading />,
    document.getElementById('heading')
);





class Assets extends React.Component<any, any> {

    timerID: any;

    constructor(props: any) {
        super(props);
    }

    componentDidMount() {
        this.timerID = setInterval(
            () => this.tick(),
            2000
          );
    }


    componentWillUnmount() {
        clearInterval(this.timerID);
      }
    


    tick() {
        var that = this;

        var addressParam = getParameterByName('address');
        console.log("address info", addressParam)
        
        fetch('http://localhost:5000/api/assets/' + addressParam)
            .then(results => {
                return results.json();
            })
            .then(data => {
                let assets = data.map((asset: any) => {

                    console.log("dumping asset", asset);

                    return (
                        <div>
                            <nav className="level">
                                <p className="level-item has-text-centered">
                                    <figure className="image">
                                        <img src={asset.blobUri} />
                                    </figure>
                                </p>
                                <p className="">
                                    <article className="media">
                                        <div className="media-content">
                                            <div className="field">
                                                <p className="control">
                                                    <textarea className="textarea" placeholder="Add a comment..."></textarea>
                                                </p>
                                            </div>
                                            
                                            <a className="button is-info">Submit</a>
                                        </div>
                                    </article>
                                    <div className="field is-grouped is-grouped-multiline margin-top-20">

                                        <div className="control">
                                            <div className="tags has-addons">
                                            <span className="tag is-dark">source</span>
                                            <span className="tag is-success">{asset.source}</span>
                                            </div>
                                        </div>
                                    </div>
                                </p>
                            </nav>

                            

                            <hr />
                        </div>
                    )
                })

                console.log("dumping assets", assets);

                that.setState({ assets: assets });

                console.log("component did mount", that.state.scrapjobs);
            })
    }


    public render() {

        if (this.state == null) {
            return (
                <div></div>
            )
        }
        console.log("rendering!", this.state);

        return (
            <div>
                {this.state.assets}
            </div>
        )
    }
    
}




ReactDOM.render(
    <Assets />,
    document.getElementById('app')
);