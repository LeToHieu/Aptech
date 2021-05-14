import React, {Component} from 'react';
//import './MainScreen.css'
export default class MainScreen extends Component {
    async componentDidMount() {
        const {products} = this.props
        debugger
    }
    render() {        
        const {x, y} = this.props //da hoc tu buoi 1        
        const {name, email} = this.props.person
        const {products} = this.props
        //lam the nao de hien ra table tu danh sach products
        //bt nay mn da lam voi jquery
        return <div>
            <h1>Day la trang Main day ne</h1>
            <h2>Ban da truyen x = {x}, y = {y} </h2>
            <h2>Ban da truyen name = {name}, y = {email} </h2>

        </div>
    }
}