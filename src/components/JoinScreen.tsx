import React, { FC, useState } from "react"
import styled from "styled-components/macro"
import { useDotNetify } from "use-dotnetify"

const Container = styled.div`
  display: flex;
  width: 100%;
  flex-direction: column;
  align-items: center;
`

const Inupt = styled.input`
  text-align: center;
  border: 1px solid gray;
  display: block;
  width: 80%;
  font-size: 10vh;

  &:focus {
    outline: 1px;
  }
`

export const JoinScreen: FC = () => {
  const [code, setCode] = useState("")
  const [state, vm] = useDotNetify("Turtl", { Games: {} })

  return (
    <Container>
      <label>Enter Game Code</label>
      <Inupt
        type="text"
        name="code"
        value={code}
        onChange={e => setCode(e.target.value)}
        autoFocus
      />
    </Container>
  )
}
