import StudentList from "./StudentList"
import {InputGroup,Form, Col, 
    Button,
    Row, Dropdown} from 'react-bootstrap';
import DatePicker from "react-datepicker";
import "react-datepicker/dist/react-datepicker.css"

function Main() {
    //JSX
    return <div className="container">
        <h1>Input student information</h1>
        <Row className="mb-3">
            <Form.Label column sm="2">
            Student Name
            </Form.Label>
            <Col sm="10">
                <Form.Control placeholder="Enter your name" />
            </Col>
        </Row>        
        <Row className="mb-3">
            <Form.Label column sm="2">
            Date of Birth
            </Form.Label>
            <Col sm="10">
                <DatePicker
                        placeholderText="Enter your DOB"
                        onSelect={() => {

                        }} //when day is clicked
                        onChange={() => {

                        }} //only when value has changed
                    />
            </Col>
        </Row>
        <Row className="mb-3">
            <Form.Label column sm="2">
                Gender
            </Form.Label>
            <Col sm="10">
                <Row>
                    <Form.Check 
                        className="ms-2"
                        type={'radio'}
                        id={`default-radio`}
                        name ={"gender"}
                        label={"Male"} />
                    <Form.Check 
                        className="ms-2"
                        type={'radio'}
                        name ={"gender"}
                        id={`default-radio`}
                        label={`Female`} />
                </Row>                
            </Col>
        </Row>
        <Row className="mb-3">
            <Form.Label column sm="2">
                Language
            </Form.Label>
            <Col sm="10">                
                <InputGroup>
                    <Form.Check 
                        className="ms-2"
                        type={'checkbox'}
                        id={`default-radio`}
                        name ={"language"}
                        label={"English"} />                    
                    
                    <Form.Check 
                        className="ms-2"
                        type={'checkbox'}
                        id={`default-radio`}
                        name ={"language"}
                        label={"Vietnamese"} />                    
                </InputGroup>                             
            </Col>
        </Row>
        <Row className="mb-3">
            <Form.Label column sm="2">
                Student Class
            </Form.Label>
            <Col sm="5">                
            <Row>
                    <Col>
                        <Dropdown>
                            <Dropdown.Toggle variant="success" id="dropdown-basic">
                                Dropdown Button
                            </Dropdown.Toggle>

                            <Dropdown.Menu>
                                <Dropdown.Item href="#/action-1">Action</Dropdown.Item>
                                <Dropdown.Item href="#/action-2">Another action</Dropdown.Item>
                                <Dropdown.Item href="#/action-3">Something else</Dropdown.Item>
                            </Dropdown.Menu>
                        </Dropdown>
                    </Col>
                <Col>
                    <Button className="btn ms-2" variant="outline-primary">Add class</Button>                    
                </Col>
            </Row>                                
            </Col>
        </Row>
        
        <StudentList />
    </div>
}
export default Main