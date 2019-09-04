import React, { FC } from "react"
import { BrowserRouter } from "react-router-dom"
import { DotNetifyProvider } from "use-dotnetify"

export const Providers: FC = props => {
  return (
    <BrowserRouter>
      <DotNetifyProvider>{props.children}</DotNetifyProvider>
    </BrowserRouter>
  )
}
