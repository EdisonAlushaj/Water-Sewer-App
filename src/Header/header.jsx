import { useEffect } from "react";

function Header() {

    return (
        <>
            <nav className="navbar navbar-expand-lg navbar-light d-flex justify-content-center" style={{ width: '100%', height: '100px', zIndex: '2', position: 'absolute'}}>
                <div className="container-fluid d-flex justify-content-center" style={{ width: '100%'}}>
                    <a className="navbar-brand" style={{ color: 'white'}} href="#">Water Sewer</a>
                    <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                        <span className="navbar-toggler-icon"></span>
                    </button>
                    <div className="collapse navbar-collapse justify-content-center"  id="navbarNav">
                        <ul className="navbar-nav">
                            <li className="nav-item" >
                                <a className="nav-link active" aria-current="page" href="#" style={{ color: 'white'}}>Home</a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" href="#" style={{ color: 'white'}}>About Us</a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" href="#" style={{ color: 'white'}}>Services</a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" href="#" style={{ color: 'white'}}>Projects</a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" href="#" style={{ color: 'white'}}>Contact Us</a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link disabled" href="#" tabindex="-1" aria-disabled="true" style={{ color: 'white'}}>Disabled</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
        </>
    )
}

export default Header