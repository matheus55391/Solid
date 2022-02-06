import React, {useState} from 'react';

import {Grid, TextField, Button} from '@material-ui/core';

export function Login(){

    const [username, setUsername] = useState("")
    // const [password, setPassword] = useState("")
    // const [confirmPassword, setConfirmPassword] = useState("")
    // const [email, setEmail] = useState("")

    return (
        <Grid 
        container
        justifyContent="center"
        alignItems="center"
        direction="column">
            <Button onClick={() => console.log(username)}>Teste</Button>
            <TextField onChange={e => setUsername(e.target.value)}/>
        </Grid>
    );
}